using App.Core.Services;
using App.Windows.View;
using Apps.Core.Contracts;
using Electronics_Store.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Apps.Core.Services;
using Microsoft.Data.SqlClient;

namespace Electronics_Store.Forms
{
    public partial class MainForm : Form
        {
        private Button _activeButton;

        private readonly Color NavNormalBlack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBlack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;
        ICustomerService _customerService;
        

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
            _customerService = new DBCustomerService();

        }
         private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;


            if (_activeButton != null)
            {
                _activeButton.BackColor = NavNormalBlack;
                _activeButton.ForeColor = NavNormalFore;
                _activeButton.Font = new Font(_activeButton.Font, FontStyle.Regular);

            }
            //set
            _activeButton = btn;
            _activeButton.BackColor = NavNormalBlack;
            _activeButton.ForeColor = NavNormalFore;
            _activeButton.Font = new Font(_activeButton.Font, FontStyle.Bold);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {

                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;
            }
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(view);



        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }

        private void bntdashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
        }
    }
}
