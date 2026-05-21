using System;
using Apps.Core.Contracts;
using Apps.Core.Models;
using Apps.Core.Services;
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

namespace App.Windows.Views
{
    public partial class OrderView : UserControl
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly string connectionString;
        public OrderView()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;
            _customerService = new DBCustomerService();
            _productService = new DBProductService(connectionString);

            this.Load += OrderView_Load;
        }
        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var customers = _customerService.GetAll();
            var products = _productService.GetAll();

            cmbcustomer.DataSource = null;
            cmbProduct.DataSource = null;

            cmbcustomer.DataSource = customers;
            cmbProduct.DataSource = products;

            cmbcustomer.DisplayMember = "Name";
            cmbcustomer.ValueMember = "Id";

            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";


        }
        private void tblorderview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvselectedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbcustomer_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)cmbProduct.SelectedItem;

            int qty = (int)numericQuantity.Value;

            foreach (DataGridViewRow row in dgvselectedProduct.Rows)
            {
                if (row.Cells["ProductId"].Value.ToString() == product.Id)
                {
                    int existingQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    existingQty += qty;

                    row.Cells["Quantity"].Value = existingQty;

                    decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    row.Cells["Total"].Value = existingQty * price;

                    return;
                }
            }

            dgvselectedProduct.Rows.Add(
                product.Id,
                product.Name,
                qty,
                product.Price,
                product.Price * qty
            );
        }

        private void tbsearchcustomer_TextChanged(object sender, EventArgs e)
        {
            string query = tbsearchcustomer.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadData(); // reload all customers
                return;
            }

            var result = _customerService.Search(query);

            cmbcustomer.DataSource = null;
            cmbcustomer.DataSource = result;

            cmbcustomer.DisplayMember = "Name";
            cmbcustomer.ValueMember = "Id";

            if (result.Count > 0)
            {
                cmbcustomer.SelectedIndex = 0;
            }
        }

        private void tbsearchProduct_TextChanged(object sender, EventArgs e)
        {
            string query = tbsearchProduct.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadData();
                return;
            }

            var result = _productService.Search(query, null, null);

            cmbProduct.DataSource = null;
            cmbProduct.DataSource = result;

            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";

            if (result.Count > 0)
            {
                cmbProduct.SelectedIndex = 0;
            }
        }
    }
}
