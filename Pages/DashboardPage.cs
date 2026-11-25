namespace SmartCampus;

public partial class DashboardPage : UserControl
{
    private readonly List<(Label Label, int Target, string Format)> _counters = [];
    private DateTime _started;

    public DashboardPage()
    {
        InitializeComponent();
        Theme.Apply(this);
        colTodayStatus.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
    }

    public void Bind(ICampusRepository repository)
    {
        dgvToday.Rows.Clear();
        foreach (var a in repository.GetAttendance()) dgvToday.Rows.Add(a.Student, a.Course, a.Time, a.Status);

        _counters.Clear();
        _counters.Add((lblStudentsValue, 1284, "N0"));
        _counters.Add((lblOnCampusValue, 936, "N0"));
        _counters.Add((lblAttendanceValue, 948, "percent"));
        _counters.Add((lblRoomsValue, 28, "rooms"));
        foreach (var counter in _counters) counter.Label.Text = "0";

        _started = DateTime.UtcNow;
        tmrCounters.Start();
    }

    private void tmrCounters_Tick(object? sender, EventArgs e)
    {
        var elapsed = (DateTime.UtcNow - _started).TotalMilliseconds;
        for (var i = 0; i < _counters.Count; i++)
        {
            var item = _counters[i];
            var progress = Math.Clamp((elapsed - i * 110) / 850d, 0d, 1d);
            var current = (int)Math.Round(item.Target * (1d - Math.Pow(1d - progress, 3d)));
            item.Label.Text = item.Format switch
            {
                "percent" => $"{current / 10d:0.0}%",
                "rooms" => $"{current} / 34",
                _ => current.ToString("N0")
            };
        }
        if (elapsed >= _counters.Count * 110 + 900) tmrCounters.Stop();
    }
}
