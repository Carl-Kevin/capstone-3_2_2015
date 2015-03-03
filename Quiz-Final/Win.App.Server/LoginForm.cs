using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Win.App.Server
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        string username = "Myusername";

        string password = "Mypassword";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Welcome to the system Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                //MainScreen frmMain = new MainScreen();
                //frmMain.Show();

            }


            else
            {
                MessageBox.Show("Error : Make sure you input a valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to QUIT?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }

            else
            {

                System.Environment.Exit(1);
            }
        }


    }
}
