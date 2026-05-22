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
        public static OrderView Instance;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly string connectionString;
        private readonly IOrderService _orderService;
        public static event Action OrderCreated;
        public OrderView()
        {
            InitializeComponent();
            Instance = this;
            connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;
            _orderService = new DBOrderService(connectionString);
            _customerService = new DBCustomerService();
            _productService = new DBProductService(connectionString);

            this.Load += OrderView_Load;
            ApplyModernUI();
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
                    UpdateTotalAmount();

                    return;
                }
            }

            dgvselectedProduct.Rows.Add(
                product.Id,
                product.Name,
                qty,
                product.Price,
                product.Price * qty,
                "Edit",
                "Delete"

            );
            UpdateTotalAmount();
            OrderCreated?.Invoke();
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
        private void ApplyModernUI()
        {
            // Main Background
            this.BackColor = Color.FromArgb(245, 247, 250);

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            panel1.Padding = new Padding(20);
            panel2.Padding = new Padding(20);

            // Panels Border Style
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle;

            // Labels
            Font labelFont = new Font("Segoe UI", 10, FontStyle.Bold);

            lbcustomer.Font = labelFont;
            lbProduct.Font = labelFont;
            label1.Font = labelFont;

            // TextBoxes
            StyleTextBox(tbsearchcustomer);
            StyleTextBox(tbsearchProduct);

            // ComboBoxes
            StyleComboBox(cmbcustomer);
            StyleComboBox(cmbProduct);

            // NumericUpDown
            numericQuantity.Font = new Font("Segoe UI", 10);
            numericQuantity.Height = 35;

            // Button
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.BackColor = Color.FromArgb(0, 120, 215);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAddProduct.Height = 40;
            btnAddProduct.Cursor = Cursors.Hand;

            // DataGridView Design
            dgvselectedProduct.BackgroundColor = Color.White;
            dgvselectedProduct.BorderStyle = BorderStyle.None;
            dgvselectedProduct.EnableHeadersVisualStyles = false;

            dgvselectedProduct.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvselectedProduct.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvselectedProduct.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvselectedProduct.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvselectedProduct.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 240, 255);

            dgvselectedProduct.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvselectedProduct.RowTemplate.Height = 35;
            dgvselectedProduct.GridColor = Color.LightGray;

            dgvselectedProduct.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvselectedProduct.RowHeadersVisible = false;

            // Better Layout Positions
            panel1.Height = 80;

            tbsearchcustomer.Width = 250;
            cmbcustomer.Width = 250;

            tbsearchProduct.Width = 250;
            cmbProduct.Width = 250;

            btnAddProduct.Width = 250;
        }
        private void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10);
            txt.BackColor = Color.White;
        }

        private void StyleComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.Font = new Font("Segoe UI", 10);
            cmb.BackColor = Color.White;
        }

        private void dgvselectedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName =
                dgvselectedProduct.Columns[e.ColumnIndex].Name;

            // DELETE
            if (columnName == "Delete")
            {
                dgvselectedProduct.Rows.RemoveAt(e.RowIndex);
                UpdateTotalAmount();
            }
            // EDIT
            if (columnName == "Edit")
            {
                DataGridViewRow row =
                    dgvselectedProduct.Rows[e.RowIndex];

                // Put values back into controls

                cmbProduct.Text =
                    row.Cells["ProductName"].Value.ToString();

                numericQuantity.Value =
                    Convert.ToDecimal(row.Cells["Quantity"].Value);

                // Remove old row
                dgvselectedProduct.Rows.RemoveAt(e.RowIndex);
                UpdateTotalAmount();
            }
        }


        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            var customer = cmbcustomer.SelectedItem as Customer;

            if (customer == null)
            {
                MessageBox.Show("Please select customer");
                return;
            }

            var order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                CustomerId = customer.Id,
                OrderDate = DateTime.Now,
                //Status 
                //PaymentMethod = 
            };

            var items = new List<OrderItem>();

            foreach (DataGridViewRow row in dgvselectedProduct.Rows)
            {
                if (row.IsNewRow) continue;

                items.Add(new OrderItem
                {
                    ProductId = row.Cells["ProductId"].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    UnitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value)
                });
            }

            _orderService.CreateOrder(order, items);

            MessageBox.Show("Order saved successfully!");
            dgvselectedProduct.Rows.Clear();
        }
        private void UpdateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvselectedProduct.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            lbtotal.Text = total.ToString("0.00");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // 1. Clear selected products grid
            dgvselectedProduct.Rows.Clear();

            // 2. Reset customer selection
            cmbcustomer.SelectedIndex = -1;

            // 3. Reset product selection
            cmbProduct.SelectedIndex = -1;

            // 4. Reset quantity
            numericQuantity.Value = 1;

            // 5. Reset total label
            lbtotal.Text = "0.00";

            MessageBox.Show("Order cancelled successfully!");
        }
    }
}
