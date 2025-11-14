using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs e)
    {
        int radius = 20;

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (SolidBrush brush = new SolidBrush(Color.SteelBlue))
        {
            e.Graphics.FillPath(brush, path);
        }

        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, Color.White);
    }
}
