using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace SmartCampus;

/// <summary>
/// Small line chart used on the Dashboard (weekly attendance %).
/// Drag it from the Toolbox like any other control.
/// </summary>
public class AttendanceChart : Control
{
    private static readonly string[] DayNames = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
    private float[] _values = [73, 82, 78, 91, 87, 96, 93];

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public float[] Values
    {
        get => _values;
        set { _values = value ?? []; Invalidate(); }
    }

    public AttendanceChart()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = Theme.Surface;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        if (_values.Length < 2 || Width < 90 || Height < 60) return;

        int w = Width - 51, h = Height - 31, ox = 37, oy = 5;
        using var muted = new SolidBrush(Theme.Muted);
        using var gridPen = new Pen(Theme.Line, 1);
        for (var n = 0; n < 4; n++)
        {
            var y = oy + n * h / 3;
            g.DrawLine(gridPen, ox, y, ox + w, y);
            g.DrawString($"{100 - n * 25}%", Font, muted, 0, y - 8);
        }

        var points = new PointF[_values.Length];
        for (var i = 0; i < _values.Length; i++)
        {
            points[i] = new PointF(ox + 5 + i * (w - 10) / (float)(_values.Length - 1), oy + h * (1 - _values[i] / 110f));
            var day = i < DayNames.Length ? DayNames[i] : "";
            g.DrawString(day, Font, muted, points[i].X - 13, oy + h + 6);
        }

        using var curve = new Pen(Theme.Accent, 3);
        g.DrawCurve(curve, points, .25f);
        using var ring = new Pen(Theme.Accent, 2);
        foreach (var p in points)
        {
            g.FillEllipse(Brushes.White, p.X - 4, p.Y - 4, 8, 8);
            g.DrawEllipse(ring, p.X - 4, p.Y - 4, 8, 8);
        }
    }
}
