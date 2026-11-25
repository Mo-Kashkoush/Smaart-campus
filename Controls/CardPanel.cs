namespace SmartCampus;

/// <summary>
/// White panel with a thin border – the "card" look used across the app.
/// Appears in the Toolbox after the first build, so you can drag it onto any form.
/// </summary>
public class CardPanel : Panel
{
    public CardPanel()
    {
        BackColor = Theme.Surface;
        Padding = new Padding(1);
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using var pen = new Pen(Theme.Line);
        e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
    }
}
