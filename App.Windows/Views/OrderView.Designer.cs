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
            panel2 = new Panel();
            numericQuantity = new NumericUpDown();
            btnAddProduct = new Button();
            dgvselectedProduct = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            cmbProduct = new ComboBox();
            tbsearchProduct = new TextBox();
            lbProduct = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbcustomer = new ComboBox();
            tbsearchcustomer = new TextBox();
            lbcustomer = new Label();
            tblorderview = new TableLayoutPanel();
            panel3 = new Panel();
            btncancel = new Button();
            btnSaveOrder = new Button();
            lbtotal = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvselectedProduct).BeginInit();
            panel1.SuspendLayout();
            tblorderview.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel2.Location = new Point(3, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 250);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(203, 142);
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(117, 31);
            numericQuantity.TabIndex = 6;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(203, 185);
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
            dgvselectedProduct.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Quantity, UnitPrice, Total, Edit, Delete });
            dgvselectedProduct.Location = new Point(455, 0);
            dgvselectedProduct.Name = "dgvselectedProduct";
            dgvselectedProduct.ReadOnly = true;
            dgvselectedProduct.RowHeadersVisible = false;
            dgvselectedProduct.RowHeadersWidth = 62;
            dgvselectedProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvselectedProduct.Size = new Size(697, 257);
            dgvselectedProduct.TabIndex = 3;
            dgvselectedProduct.CellClick += dgvselectedProduct_CellClick;
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
            // Edit
            // 
            Edit.HeaderText = "Action";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Action";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 150;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(203, 98);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(246, 33);
            cmbProduct.TabIndex = 2;
            cmbProduct.Text = "select product";
            // 
            // tbsearchProduct
            // 
            tbsearchProduct.Location = new Point(203, 51);
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
            lbProduct.Location = new Point(80, 82);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(74, 25);
            lbProduct.TabIndex = 0;
            lbProduct.Text = "Product";
            lbProduct.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbcustomer);
            panel1.Controls.Add(tbsearchcustomer);
            panel1.Controls.Add(lbcustomer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 68);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(787, 1);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 5;
            label3.Text = "Select Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, -9);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 4;
            label2.Text = "Search Customer";
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
            cmbcustomer.Location = new Point(739, 37);
            cmbcustomer.Name = "cmbcustomer";
            cmbcustomer.Size = new Size(259, 33);
            cmbcustomer.TabIndex = 2;
            // 
            // tbsearchcustomer
            // 
            tbsearchcustomer.Location = new Point(304, 40);
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
            // tblorderview
            // 
            tblorderview.ColumnCount = 1;
            tblorderview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblorderview.Controls.Add(panel1, 0, 0);
            tblorderview.Controls.Add(panel2, 0, 1);
            tblorderview.Controls.Add(panel3, 0, 2);
            tblorderview.Dock = DockStyle.Fill;
            tblorderview.Location = new Point(0, 0);
            tblorderview.Name = "tblorderview";
            tblorderview.RowCount = 3;
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3223219F));
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 52.9235458F));
            tblorderview.RowStyles.Add(new RowStyle(SizeType.Percent, 31.7541351F));
            tblorderview.Size = new Size(1083, 484);
            tblorderview.TabIndex = 0;
            tblorderview.Paint += tblorderview_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(btncancel);
            panel3.Controls.Add(btnSaveOrder);
            panel3.Controls.Add(lbtotal);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 333);
            panel3.Name = "panel3";
            panel3.Size = new Size(1077, 148);
            panel3.TabIndex = 2;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(652, 85);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 3;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(841, 85);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(112, 34);
            btnSaveOrder.TabIndex = 2;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.Location = new Point(500, 34);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(0, 25);
            lbtotal.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 34);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Bill :";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblorderview);
            Name = "OrderView";
            Size = new Size(1083, 484);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvselectedProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tblorderview.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private NumericUpDown numericQuantity;
        private Button btnAddProduct;
        private DataGridView dgvselectedProduct;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
        private ComboBox cmbProduct;
        private TextBox tbsearchProduct;
        private Label lbProduct;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbcustomer;
        private TextBox tbsearchcustomer;
        private Label lbcustomer;
        private TableLayoutPanel tblorderview;
        private Panel panel3;
        private Button btnSaveOrder;
        private Label lbtotal;
        private Label label4;
        private Button btncancel;
    }
}
