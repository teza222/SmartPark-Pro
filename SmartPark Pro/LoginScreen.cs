using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPark_Pro;

namespace SmartPark_Pro
{
    public partial class LoginScreen : Form
    {
        SmartParkProDbEntities _db;
        private static LoginScreen _instance;
        public LoginScreen()
        {
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            InitializeComponent();
            _db = new SmartParkProDbEntities();

        }

        //Singleton form
        public static LoginScreen Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new LoginScreen();
                }
                return _instance;
            }
        }

        private void _showManageLotScreen()
        {
            this.Hide();

            //Showing the managelot screen in the center of the mdi parent on load
            ManageLotScreen manageLot = ManageLotScreen.Instance;
            MainScreen mainMDIWindow = new MainScreen();
            manageLot.MdiParent = this.MdiParent;
            manageLot.Show();
            manageLot.BringToFront();
            manageLot.Focus();

        }

        private async void loginbnt_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            try
            {
               
                SHA256 sha = SHA256.Create();
                if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
                {
                    MessageBox.Show("Please enter username and password");
                    return;
                }
                    loadingForm.StartPosition = FormStartPosition.Manual;
                    loadingForm.Location = new Point(
                        this.Location.X + (this.Width - loadingForm.Width) / 2,
                        this.Location.Y + (this.Height - loadingForm.Height) / 2
                    );

                    loadingForm.Show();
                    loadingForm.Refresh();
                    var userName = tbUsername.Text.Trim();
                    var password = tbPassword.Text.Trim();

                //Convert the password to a byte array and hash it
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                password = Convert.ToBase64String(hash);



                //add a user to the database
                UserAccount userACC = new UserAccount();
                userACC.UserName = userName;
                userACC.Password = password;
                //userACC.Role = "admin";
                //_db.UserAccounts.AddOrUpdate(userACC);
                //_db.SaveChanges();



                var user = _db.UserAccounts.Where(u => u.UserName == userName && u.Password == password).FirstOrDefault();
                    if (user != null)
                    {
                        _showManageLotScreen();

                        if (this.MdiParent is MainScreen parentForm)
                        {
                            parentForm.EnableMenus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }

                    loadingForm.Close();

            }
            catch (Exception ex)
            {
                loadingForm.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
           
               
        }

      
    }
}