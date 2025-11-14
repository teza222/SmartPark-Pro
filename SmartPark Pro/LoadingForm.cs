using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

public class LoadingForm : Form
{
    private PictureBox spinner;

    public LoadingForm()
    {
        // Form Settings
        this.Text = "Loading...";
        this.Size = new Size(150, 150);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.CenterParent;
        this.ControlBox = false;
        this.TopMost = true;

        // Spinner Settings
        spinner = new PictureBox
        {
            Size = new Size(50, 50),
            Image = SmartPark_Pro.Properties.Resources.loader,
            SizeMode = PictureBoxSizeMode.StretchImage
        };

        // Center spinner
        spinner.Location = new Point((this.ClientSize.Width - spinner.Width) / 2,
                                     (this.ClientSize.Height - spinner.Height) / 2);

        this.Controls.Add(spinner);
        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // LoadingForm
            // 
            this.ClientSize = new System.Drawing.Size(134, 111);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoadingForm";
            this.ResumeLayout(false);

    }
}