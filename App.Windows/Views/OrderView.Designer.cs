namespace App.Windows.Views
{
    partial class OrderView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblorderview = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            cmbcustomer = new ComboBox();
            tbsearchcustomer = new TextBox();
            lbcustomer = new Label();
            panel2 = new Panel();
            numericQuantity = new NumericUpDown();
            btnAddProduct = new Button();
            dgvselectedProduct = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            cmbProduct = new ComboBox();
            tbsearchProduct = new TextBox();
            lbProduct = new Label();
            tblorderview.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvselectedProduct).BeginInit();
            SuspendLayout();
            // 
            // tblorderview
            // 
            tblorderview.ColumnCount = 1;
            tblorderview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblorderview.Controls.Add(panel1, 0, 0);
            tblorderview.Controls.Add(panel2, 0, 1);
            tblorderview.Dock = DockStyle.Fill;
            tblorderview.Location = new Point(0, 0);
            tblorderview.Name = "tblorderview";
            tblorderview.RowCount = 3;
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7589989F));
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5256271F));
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 32.7153778F));
            tblorderview.Size = new Size(1083, 484);
            tblorderview.TabIndex = 0;
            tblorderview.Paint += tblorderview_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbcustomer);
            panel1.Controls.Add(tbsearchcustomer);
            panel1.Controls.Add(lbcustomer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 3;
            label1.Text = "OR";
            label1.Click += label1_Click_1;
            // 
            // cmbcustomer
            // 
            cmbcustomer.FormattingEnabled = true;
            cmbcustomer.Location = new Point(739, 15);
            cmbcustomer.Name = "cmbcustomer";
            cmbcustomer.Size = new Size(259, 33);
            cmbcustomer.TabIndex = 2;
            // 
            // tbsearchcustomer
            // 
            tbsearchcustomer.Location = new Point(304, 12);
            tbsearchcustomer.Name = "tbsearchcustomer";
            tbsearchcustomer.PlaceholderText = "search cutomer..";
            tbsearchcustomer.Size = new Size(259, 31);
            tbsearchcustomer.TabIndex = 1;
            tbsearchcustomer.TextChanged += tbsearchcustomer_TextChanged;
            // 
            // lbcustomer
            // 
            lbcustomer.AutoSize = true;
            lbcustomer.Location = new Point(73, 12);
            lbcustomer.Name = "lbcustomer";
            lbcustomer.Size = new Size(141, 25);
            lbcustomer.TabIndex = 0;
            lbcustomer.Text = "Customer Name";
            lbcustomer.Click += lbcustomer_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericQuantity);
            panel2.Controls.Add(btnAddProduct);
            panel2.Controls.Add(dgvselectedProduct);
            panel2.Controls.Add(cmbProduct);
            panel2.Controls.Add(tbsearchProduct);
            panel2.Controls.Add(lbProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 257);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(128, 142);
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(117, 31);
            numericQuantity.TabIndex = 6;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(128, 185);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(246, 34);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add  Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvselectedProduct
            // 
            dgvselectedProduct.AllowUserToAddRows = false;
            dgvselectedProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvselectedProduct.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Quantity, UnitPrice, Total });
            dgvselectedProduct.Location = new Point(380, 0);
            dgvselectedProduct.Name = "dgvselectedProduct";
            dgvselectedProduct.ReadOnly = true;
            dgvselectedProduct.RowHeadersVisible = false;
            dgvselectedProduct.RowHeadersWidth = 62;
            dgvselectedProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvselectedProduct.Size = new Size(697, 257);
            dgvselectedProduct.TabIndex = 3;
            dgvselectedProduct.CellContentClick += dgvselectedProduct_CellContentClick;
            // 
            // ProductId
            // 
            ProductId.HeaderText = "ProductId";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Width = 150;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 150;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 8;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(128, 98);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(246, 33);
            cmbProduct.TabIndex = 2;
            cmbProduct.Text = "select product";
            // 
            // tbsearchProduct
            // 
            tbsearchProduct.Location = new Point(128, 51);
            tbsearchProduct.Name = "tbsearchProduct";
            tbsearchProduct.PlaceholderText = "search product ..";
            tbsearchProduct.Size = new Size(246, 31);
            tbsearchProduct.TabIndex = 1;
            tbsearchProduct.Tag = "search product ..";
            tbsearchProduct.TextChanged += tbsearchProduct_TextChanged;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(34, 82);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(74, 25);
            lbProduct.TabIndex = 0;
            lbProduct.Text = "Product";
            lbProduct.Click += label1_Click;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblorderview);
            Name = "OrderView";
            Size = new Size(1083, 484);
            tblorderview.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvselectedProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblorderview;
        private Panel panel1;
        private ComboBox cmbcustomer;
        private TextBox tbsearchcustomer;
        private Label lbcustomer;
        private Panel panel2;
        private DataGridView dgvselectedProduct;
        private ComboBox cmbProduct;
        private TextBox tbsearchProduct;
        private Label lbProduct;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private Label label1;
        private Button btnAddProduct;
        private NumericUpDown numericQuantity;
    }
}
