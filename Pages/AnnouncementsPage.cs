using System.Text;
using System.Text.Json;

namespace SmartCampus;

public partial class AnnouncementsPage : UserControl
{
    private CampusServer _server = null!;
    private HttpClient _http = null!;
    private Action<string> _notify = _ => { };

    public AnnouncementsPage()
    {
        InitializeComponent();
        Theme.Apply(this);
    }

    public void Bind(CampusServer server, HttpClient http, Action<string> notify)
    {
        _server = server; _http = http; _notify = notify;
        LoadRecent();
    }

    private void LoadRecent()
    {
        if (_server is null) return;
        flowRecent.SuspendLayout();
        foreach (var old in flowRecent.Controls.Cast<Control>().ToList()) old.Dispose();
        flowRecent.Controls.Clear();
        foreach (var n in _server.Notices) flowRecent.Controls.Add(MakeNoticeCard(n));
        flowRecent.ResumeLayout(true);
    }

    private static CardPanel MakeNoticeCard(CampusNotice notice)
    {
        var card = new CardPanel { Size = new Size(690, 85), Margin = new Padding(0, 0, 0, 12) };
        card.Controls.Add(new Label
        {
            Text = notice.Title, Location = new Point(16, 12), Size = new Size(650, 26), AutoEllipsis = true,
            Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Theme.Ink
        });
        card.Controls.Add(new Label
        {
            Text = notice.Message, Location = new Point(16, 42), Size = new Size(650, 24), AutoEllipsis = true,
            Font = new Font("Segoe UI", 9.5F), ForeColor = Theme.Muted
        });
        return card;
    }

    private async void btnPublish_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
        {
            _notify("Enter both a title and a message.");
            return;
        }

        btnPublish.Enabled = false;
        try
        {
            var notice = new CampusNotice(txtTitle.Text.Trim(), txtMessage.Text.Trim(), DateTime.Now);

            // Send it through the local HTTP server (client -> server). If that fails, store it directly.
            var delivered = false;
            if (_server.IsRunning)
            {
                try
                {
                    using var body = new StringContent(JsonSerializer.Serialize(notice), Encoding.UTF8, "application/json");
                    var response = await _http.PostAsync($"http://127.0.0.1:{_server.Port}/notices", body);
                    delivered = response.IsSuccessStatusCode;
                }
                catch (HttpRequestException) { }
            }
            if (!delivered) _server.Publish(notice);

            if (IsDisposed) return;
            _notify("Notification published to the campus server.");
            txtTitle.Clear();
            txtMessage.Clear();
            LoadRecent();
        }
        finally
        {
            if (!IsDisposed) btnPublish.Enabled = true;
        }
    }
}
