using Apps.Core.Contracts;
using Apps.Core.Models;
using Apps.Core.Services;
using Electronics_Store.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
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
using System.Windows.Forms;

namespace App.Windows.Forms
{
    public partial class SignupForm : Form

    {
        private readonly string connectionString;
        public SignupForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            IAuthService auth = new DBAuthService(connectionString);

            if (auth.UserExists(txtEmail.Text))
            {
                MessageBox.Show("Email already exists!");
                return;
            }

            Apps.Core.Models.User user = new Apps.Core.Models.User()
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Role = "User"
            };

            auth.Register(user, txtPassword.Text);

            MessageBox.Show("Account created successfully!");
            LoginForm main = new LoginForm();
            main.Show();
            this.Hide();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }
    }
}
