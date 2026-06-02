using App.Windows.Views;
using Apps.Core.Contracts;
using Apps.Core.Services;
using Apps.Core.Utilities;
using Electronics_Store;
using Electronics_Store.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.Windows.Forms
{
    public partial class LoginForm : Form

    {
        private readonly string connectionString;
        public LoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            IAuthService auth = new DBAuthService(connectionString);

            var user = auth.Login(txtEmail.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Login Successful!");

                // Save session
                CurrentUserSession.User = user;

                // Open Dashboard
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }




        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();

            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
