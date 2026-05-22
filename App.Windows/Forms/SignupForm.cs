using Apps.Core.Contracts;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apps.Core.Services;
using System.Configuration;
using Apps.Core.Models;
using System;
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
        }
    }
}
