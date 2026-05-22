using App.Windows.Views;
using Apps.Core.Contracts;
using Apps.Core.Services;
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

namespace Electronics_Store.Views
{
    public partial class DashboardView : UserControl
    {
        IDashboardService _dashboardService;
        private readonly string connectionString;
        public DashboardView()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;
            _dashboardService = new DBDashboardService(connectionString);
            OrderView.OrderCreated += LoadDashboard;
            this.Load += DashboardView_Load;
        }
        private void DashboardView_Load(object sender, EventArgs e)
        {
            LoadDashboard();

            timer1.Start();

            DesignGrid(dgvLowStock);
            DesignGrid(dgvRecentOrders);
        }

        private void LoadDashboard()
        {
            lblSales.Text =
                _dashboardService.GetTotalProductsSold().ToString();

            lblOrders.Text =
                _dashboardService.GetTotalOrders().ToString();

            lblRevenue.Text =
                _dashboardService.GetTotalRevenue().ToString("N2") + " PKR";



            dgvLowStock.DataSource = null;
            dgvLowStock.DataSource = _dashboardService.GetLowStockProducts();
            dgvLowStock.Refresh();

            //        dgvLowStock.Columns["Name"].HeaderText =
            //"Product Name";

            //        dgvLowStock.Columns["Category"].HeaderText =
            //            "Category";

            //        dgvLowStock.Columns["Stock"].HeaderText =
            //            "Current Stock";

            foreach (DataGridViewRow row in dgvLowStock.Rows)
            {
                int stock =
                    Convert.ToInt32(row.Cells["Stock"].Value);

                if (stock <= 5)
                {
                    row.DefaultCellStyle.BackColor =
                        Color.LightCoral;
                }
            }



            dgvRecentOrders.DataSource = null;
            dgvRecentOrders.DataSource = _dashboardService.GetRecentOrders();
            dgvRecentOrders.Refresh();
        }

        private void lbsaleV_Click(object sender, EventArgs e)
        {

        }

        private void lbrevenu_Click(object sender, EventArgs e)
        {

        }
        private void DesignGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.ReadOnly = true;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // IMPORTANT: disables default OS theme on headers
            dgv.EnableHeadersVisualStyles = false;

            // HEADER STYLE (solid black, no background issue)
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // CELL STYLE
            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowTemplate.Height = 35;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.GridColor = Color.LightGray;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}
