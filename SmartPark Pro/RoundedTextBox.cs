using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private TextBox innerTextBox;

    public RoundedTextBox()
    {
        this.BackColor = Color.White;
        this.Padding = new Padding(8);

        innerTextBox = new TextBox();
        innerTextBox.BorderStyle = BorderStyle.None;
        innerTextBox.Dock = DockStyle.Fill;
        innerTextBox.Font = this.Font;

        this.Controls.Add(innerTextBox);
        this.Size = new Size(200, 35);
    }

    public string Texts
    {
        get { return innerTextBox.Text; }
        set { innerTextBox.Text = value; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = 15;
        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();

        using (Pen pen = new Pen(Color.Gray, 2))
        {
            e.Graphics.DrawPath(pen, path);
        }

        this.Region = new Region(path);
    }
    public bool UsePasswordChar
    {
        get { return innerTextBox.UseSystemPasswordChar; }
        set { innerTextBox.UseSystemPasswordChar = value; }
    }

    public char PasswordChar
    {
        get { return innerTextBox.PasswordChar; }
        set { innerTextBox.PasswordChar = value; }
    }

    public override string Text
    {
        get { return innerTextBox.Text; }
        set { innerTextBox.Text = value; }
    }


}
