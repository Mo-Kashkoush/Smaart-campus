using System.Net;
using System.Text;
using System.Text.Json;

namespace SmartCampus;

public partial class ServerPage : UserControl
{
    private CampusServer _server = null!;
    private HttpClient _http = null!;
    private Action<string> _notify = _ => { };
    private Action _serverChanged = () => { };

    public ServerPage()
    {
        InitializeComponent();
        Theme.Apply(this);
    }

    public void Bind(CampusServer server, HttpClient http, Action<string> notify, Action serverChanged)
    {
        _server = server; _http = http; _notify = notify; _serverChanged = serverChanged;
        RefreshStatus();
    }

    private void RefreshStatus()
    {
        var running = _server.IsRunning;
        lblStatusValue.Text = running ? "●  Online" : "○  Offline";
        lblStatusValue.ForeColor = running ? Theme.Green : Theme.Red;
        lblStatusUrl.Text = $"Listening on  http://127.0.0.1:{_server.Port}/";
        btnToggle.Text = running ? "Stop server" : "Start server";
        btnToggle.BackColor = running ? Theme.SoftRed : Theme.Accent;
        btnToggle.ForeColor = running ? Theme.Red : Color.White;
    }

    private void btnToggle_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_server.IsRunning) _server.Stop(); else _server.Start();
        }
        catch (HttpListenerException ex) { _notify("Server error: " + ex.Message); }
        RefreshStatus();
        _serverChanged();
    }

    private async void btnSendTest_Click(object? sender, EventArgs e)
    {
        var notice = new CampusNotice("Client test", "Message delivered from the dashboard client to the campus server.", DateTime.Now);
        using var body = new StringContent(JsonSerializer.Serialize(notice), Encoding.UTF8, "application/json");
        try
        {
            var response = await _http.PostAsync($"http://127.0.0.1:{_server.Port}/notices", body);
            if (!IsDisposed) _notify(response.IsSuccessStatusCode ? "Client message received by server." : "Server returned an error.");
        }
        catch (Exception ex)
        {
            if (!IsDisposed) _notify("Client could not connect: " + ex.Message);
        }
    }

    private async void btnHealth_Click(object? sender, EventArgs e)
    {
        try
        {
            var json = await _http.GetStringAsync($"http://127.0.0.1:{_server.Port}/health");
            MessageBox.Show(FindForm(), json, "Server health check");
        }
        catch (Exception ex)
        {
            MessageBox.Show(FindForm(), ex.Message, "Connection error");
        }
    }
}
