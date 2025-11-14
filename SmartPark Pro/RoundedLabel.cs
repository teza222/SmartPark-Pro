using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedLabel : Label
{
    public int BorderRadius { get; set; } = 20;
    public Color BorderColor { get; set; } = Color.Gray;
    public int BorderSize { get; set; } = 2;
    public Color BackgroundColor { get; set; } = Color.White;

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        GraphicsPath path = new GraphicsPath();
        int r = BorderRadius;

        path.AddArc(rect.X, rect.Y, r, r, 180, 90);
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
        path.CloseFigure();

        using (SolidBrush brush = new SolidBrush(BackgroundColor))
            e.Graphics.FillPath(brush, path);

        using (Pen pen = new Pen(BorderColor, BorderSize))
            e.Graphics.DrawPath(pen, path);

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }
}
