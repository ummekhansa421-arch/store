using Apps.Core.Contracts;
using Apps.Core.Models;
using Apps.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.Windows.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;
        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
        {
            InitializeComponent();

            numstock.Maximum = Int32.MaxValue;
            numprice.Maximum = decimal.MaxValue;


            cmbcategory.Items.Clear();
            cmbcategory.DataSource = Enum.GetNames(typeof(ProductCategoryEnum));
            cmbcategory.SelectedIndex = 0;

            cmbstatus.Items.Clear();
            cmbstatus.DataSource = Enum.GetNames(typeof(ProductCategoryStatus));
            cmbstatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;
            if (mode == ProductFormModeEnum.Edit)
            {
                btnsave.Text = "update";
            }
            else if (mode == ProductFormModeEnum.View)
            {

                btnsave.Visible = false;
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {

                txtid.Text = p.Id;
                txtname.Text = p.Name;
                cmbcategory.SelectedItem = p.Category.ToString();
                cmbstatus.SelectedItem = p.Status.ToString();
                numprice.Value = p.Price;
                numstock.Value = p.Stock;

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtname.Text;
                newProduct.Category = (ProductCategoryEnum)Enum.Parse(
               typeof(ProductCategoryEnum),
               cmbcategory.SelectedItem.ToString()
                );
                newProduct.Status = (ProductCategoryStatus)Enum.Parse(
                typeof(ProductCategoryStatus),
                cmbstatus.SelectedItem.ToString()
                 );
                newProduct.Price = numprice.Value;
                newProduct.Stock = (int)numstock.Value;


                //                _product =_service.Add(newProduct);
                //                txtid.Text = _product.Id;


                Product temp = _service.Add(newProduct);
                txtid.Text = temp?.Id.ToString() ?? "";



            }
            else if (_mode == ProductFormModeEnum.Edit)
            {

                _product.Name = txtname.Text;
                _product.Category = (ProductCategoryEnum)Enum.Parse(
               typeof(ProductCategoryEnum),
               cmbcategory.SelectedItem.ToString()
                );
                _product.Status = (ProductCategoryStatus)Enum.Parse(
                typeof(ProductCategoryStatus),
                cmbstatus.SelectedItem.ToString()
            );
                _product.Price = numprice.Value;
                _product.Stock = (int)numstock.Value;

                bool isUpdated = _service.Update(_product);

            }
            this.Close();

        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
