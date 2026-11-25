using System.Net;

namespace SmartCampus;

public partial class MainForm : Form
{
    private static readonly Dictionary<string, string> NavIcons = new()
    {
        ["Dashboard"] = "◫", ["Students"] = "♙", ["Attendance"] = "◷",
        ["Rooms"] = "▦", ["Announcements"] = "◉", ["Server & API"] = "⇄"
    };

    private ICampusRepository _repository = null!;
    private CampusServer _server = null!;
    private readonly HttpClient _http = new();

    // Room data is shared between the Rooms page and the Resources window.
    private readonly List<CampusRoom> _managedRooms = [];
    private readonly List<(DateTime Date, TimeSpan Start, TimeSpan End)> _roomSlots = [];
    private readonly List<(string Room, DateTime Date, TimeSpan Start, TimeSpan End)> _roomBlocks = [];
    private bool _roomsSeeded;

    private UserControl? _currentView;
    private string _currentPage = "Dashboard";
    private int _navWidth = 278;
    private bool _navCollapsed;
    private bool _navWide = true;

    public MainForm()
    {
        InitializeComponent();
        DoubleBuffered = true;
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;

        _repository = CreateRepository();
        _server = new CampusServer();
        _server.ClientConnected += _ => { if (IsHandleCreated && !IsDisposed) BeginInvoke(ShowServerStatus); };
        try { _server.Start(); }
        catch (HttpListenerException) { }
        ShowServerStatus();
        UpdateClock();
        tmrClock.Start();
        tmrPulse.Start();
    }

    private static ICampusRepository CreateRepository()
    {
        var connectionString = Environment.GetEnvironmentVariable("SMARTCAMPUS_SQL");
        if (!string.IsNullOrWhiteSpace(connectionString))
        {
            try
            {
                var repository = new SqlServerCampusRepository(connectionString);
                repository.EnsureConnection();
                return repository;
            }
            catch (Exception)
            {
                MessageBox.Show("SQL Server connection failed. The application will open in demo mode. Check SMARTCAMPUS_SQL and run Database\\schema.sql.", "Database connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        return new DemoCampusRepository();
    }

    // ---- Navigation -------------------------------------------------------
    private IEnumerable<Button> NavButtons =>
        [btnNavDashboard, btnNavStudents, btnNavAttendance, btnNavRooms, btnNavAnnouncements, btnNavServer];

    private void MainForm_Shown(object? sender, EventArgs e) => ShowPage("Dashboard");

    private void NavButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button { Tag: string page }) ShowPage(page);
    }

    private void btnSettings_Click(object? sender, EventArgs e) => ShowToast("Settings are ready for course-specific configuration.");

    private void btnMenu_Click(object? sender, EventArgs e)
    {
        _navCollapsed = !_navCollapsed;
        tmrNav.Start();
    }

    private void tmrNav_Tick(object? sender, EventArgs e)
    {
        var target = _navCollapsed ? 78 : 278;
        _navWidth += Math.Sign(target - _navWidth) * Math.Min(22, Math.Abs(target - _navWidth));
        pnlSidebar.Width = _navWidth;
        ApplyNavState();
        if (_navWidth == target) tmrNav.Stop();
    }

    private void ApplyNavState()
    {
        var wide = _navWidth > 150;
        if (wide == _navWide) return;
        _navWide = wide;
        lblBrandTitle.Visible = lblBrandSub.Visible = lblWorkspace.Visible = lblSystem.Visible = wide;
        btnSettings.Visible = pnlServerCard.Visible = wide;
        foreach (var button in NavButtons)
        {
            var page = (string)button.Tag!;
            button.Text = wide ? $"   {NavIcons[page]}     {page}" : NavIcons[page];
            button.TextAlign = wide ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleCenter;
        }
    }

    private void UpdateNavSelection()
    {
        foreach (var button in NavButtons)
        {
            var selected = (string)button.Tag! == _currentPage;
            button.BackColor = selected ? Theme.Accent : Theme.Sidebar;
            button.ForeColor = selected ? Color.White : Theme.Ink;
        }
    }

    // ---- Pages ------------------------------------------------------------
    private void ShowPage(string page)
    {
        _currentPage = page;
        lblPageTitle.Text = page;
        UpdateNavSelection();

        var view = CreatePage(page);
        view.Dock = DockStyle.Fill;

        pnlContent.SuspendLayout();
        var old = _currentView;
        pnlContent.Controls.Add(view);
        if (old is not null) { pnlContent.Controls.Remove(old); old.Dispose(); }
        _currentView = view;
        pnlContent.ResumeLayout(true);
    }

    private UserControl CreatePage(string page)
    {
        switch (page)
        {
            case "Students":
            {
                var p = new StudentsPage();
                p.Bind(_repository, ShowToast);
                return p;
            }
            case "Attendance":
            {
                var p = new AttendancePage();
                p.Bind(_repository);
                return p;
            }
            case "Rooms":
            {
                EnsureRoomData();
                var p = new RoomsPage();
                p.Bind(_repository, _managedRooms, _roomSlots, _roomBlocks, ShowToast);
                return p;
            }
            case "Announcements":
            {
                var p = new AnnouncementsPage();
                p.Bind(_server, _http, ShowToast);
                return p;
            }
            case "Server & API":
            {
                var p = new ServerPage();
                p.Bind(_server, _http, ShowToast, ShowServerStatus);
                return p;
            }
            default:
            {
                var p = new DashboardPage();
                p.Bind(_repository);
                return p;
            }
        }
    }

    private void EnsureRoomData()
    {
        if (_roomsSeeded) return;
        _roomsSeeded = true;
        _managedRooms.AddRange(_repository.GetRooms());
        _roomSlots.Add((DateTime.Today, TimeSpan.FromHours(9), TimeSpan.FromHours(11)));
        _roomSlots.Add((DateTime.Today, TimeSpan.FromHours(12), TimeSpan.FromHours(14)));
    }

    // ---- Top bar / toast / server badge -----------------------------------
    private void tmrClock_Tick(object? sender, EventArgs e) => UpdateClock();

    private void UpdateClock() => lblClock.Text = DateTime.Now.ToString("ddd, MMM dd  ·  hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);

    private void ShowServerStatus()
    {
        if (IsDisposed) return;
        lblServerBadge.Text = _server.IsRunning ? $"●  Server online  ·  :{_server.Port}" : "○  Server offline";
        lblServerBadge.ForeColor = _server.IsRunning ? Theme.Green : Theme.Red;
        lblServerCardPort.Text = $"Listening on :{_server.Port}";
    }

    private void tmrPulse_Tick(object? sender, EventArgs e)
    {
        if (_server.IsRunning)
            lblServerBadge.BackColor = lblServerBadge.BackColor == Theme.SoftGreen ? Color.FromArgb(218, 218, 218) : Theme.SoftGreen;
    }

    private void ShowToast(string message)
    {
        if (IsDisposed) return;
        lblToast.Text = "✓   " + message;
        lblToast.Visible = true;
        PositionToast();
        lblToast.BringToFront();
        tmrToast.Stop();
        tmrToast.Start();
    }

    private void PositionToast() =>
        lblToast.Location = new Point(ClientSize.Width - lblToast.Width - 28, ClientSize.Height - lblToast.Height - 28);

    private void MainForm_Resize(object? sender, EventArgs e) => PositionToast();

    private void tmrToast_Tick(object? sender, EventArgs e)
    {
        lblToast.Visible = false;
        tmrToast.Stop();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        tmrClock.Stop();
        _http.Dispose();
        _server?.Dispose();
        base.OnFormClosed(e);
    }
}
