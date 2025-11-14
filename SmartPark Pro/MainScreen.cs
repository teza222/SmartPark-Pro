using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPark_Pro
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "SmartPark Pro";
            ChangeMdiBackgroundColor();
            manageLotToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;


        }
        public void EnableMenus()
        {
            manageLotToolStripMenuItem.Visible = true;
            reportsToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = true;
            loginToolStripMenuItem1.Visible = false;
        }

        public void DisableMenus()
        {
            manageLotToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            loginToolStripMenuItem1.Visible = true;
        }

        private void ChangeMdiBackgroundColor()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Gainsboro; // choose any color you want
                }
            }
        }




        private void MainScreen_Load(object sender, EventArgs e)
        {
            _showLoginScreen();
        }

        private void loginToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                // Close each child form
                childForm.Close();
            }
            _showLoginScreen();
        }

        

        

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageLotToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                // Close each child form
                childForm.Close();
            }
            //Showing the managelot screen in the center of the mdi parent on load
            ManageLotScreen manageLotScreen = ManageLotScreen.Instance;
            MainScreen mainScreen = new MainScreen();
            manageLotScreen.MdiParent = this;
            manageLotScreen.Show();
            manageLotScreen.BringToFront();
            manageLotScreen.Focus();


        }

        private void allCarsInLotToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                // Close each child form
                childForm.Close();
            }
            //Showing the allcarreport screen in the center of the mdi parent on load
            AllCarReport allCarReport = AllCarReport.Instance;
            allCarReport.MdiParent = this;
            allCarReport.Show();
            allCarReport.BringToFront();
            allCarReport.Focus();

        }

        private void fiancialReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                // Close each child form
                childForm.Close();
            }
            //Showing the financialreport screen in the center of the mdi parent on load
            FinacialReport finacialReport = FinacialReport.Instance;
            finacialReport.MdiParent = this;
            finacialReport.Show();
            finacialReport.BringToFront();
            finacialReport.Focus();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                // Close each child form
                childForm.Close();
            }
            DisableMenus();
            _showLoginScreen();


        }
        private void _showLoginScreen()
        {

            //Showing the login screen in the center of the mdi parent on load
            LoginScreen loginScreen = LoginScreen.Instance;

            loginScreen.MdiParent = this;
            // Set the StartPosition to Manual
            loginScreen.StartPosition = FormStartPosition.Manual;

            // Calculate the center position
            int x = (this.ClientSize.Width - loginScreen.Width) / 2;
            int y = (this.ClientSize.Height - loginScreen.Height) / 2;

            // Set the location of the child form
            loginScreen.Location = new Point(x, y);
            loginScreen.Show();
            loginScreen.BringToFront();
            loginScreen.Focus();

        }
    }
}
