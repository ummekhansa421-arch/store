namespace Electronics_Store.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnldashboard = new Panel();
            panel2 = new Panel();
            pnlContainer = new Panel();
            pnlsidebar = new Panel();
            bntdashboard = new Button();
            btnReports = new Button();
            btnPlaceOrder = new Button();
            btnEmployees = new Button();
            btnSales = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            panel1 = new Panel();
            lbleft = new Label();
            pnldashboard.SuspendLayout();
            panel2.SuspendLayout();
            pnlsidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnldashboard
            // 
            pnldashboard.Controls.Add(panel2);
            pnldashboard.Controls.Add(panel1);
            pnldashboard.Dock = DockStyle.Fill;
            pnldashboard.Location = new Point(0, 0);
            pnldashboard.Margin = new Padding(3, 4, 3, 4);
            pnldashboard.Name = "pnldashboard";
            pnldashboard.Size = new Size(1198, 859);
            pnldashboard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlContainer);
            panel2.Controls.Add(pnlsidebar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 734);
            panel2.TabIndex = 3;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(222, 0);
            pnlContainer.Margin = new Padding(3, 4, 3, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(976, 734);
            pnlContainer.TabIndex = 1;
            // 
            // pnlsidebar
            // 
            pnlsidebar.Controls.Add(bntdashboard);
            pnlsidebar.Controls.Add(btnReports);
            pnlsidebar.Controls.Add(btnPlaceOrder);
            pnlsidebar.Controls.Add(btnEmployees);
            pnlsidebar.Controls.Add(btnSales);
            pnlsidebar.Controls.Add(btnCustomers);
            pnlsidebar.Controls.Add(btnProducts);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 0);
            pnlsidebar.Margin = new Padding(3, 4, 3, 4);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(222, 734);
            pnlsidebar.TabIndex = 0;
            // 
            // bntdashboard
            // 
            bntdashboard.Location = new Point(44, 38);
            bntdashboard.Margin = new Padding(3, 4, 3, 4);
            bntdashboard.Name = "bntdashboard";
            bntdashboard.Size = new Size(133, 62);
            bntdashboard.TabIndex = 13;
            bntdashboard.Text = "Dashboard";
            bntdashboard.UseVisualStyleBackColor = true;
            bntdashboard.Click += bntdashboard_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(44, 552);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(133, 62);
            btnReports.TabIndex = 12;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(44, 298);
            btnPlaceOrder.Margin = new Padding(3, 4, 3, 4);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(133, 62);
            btnPlaceOrder.TabIndex = 11;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(44, 465);
            btnEmployees.Margin = new Padding(3, 4, 3, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(133, 62);
            btnEmployees.TabIndex = 10;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(44, 380);
            btnSales.Margin = new Padding(3, 4, 3, 4);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(133, 62);
            btnSales.TabIndex = 9;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(44, 211);
            btnCustomers.Margin = new Padding(3, 4, 3, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(133, 62);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(44, 121);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(133, 62);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbleft);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbleft
            // 
            lbleft.AutoSize = true;
            lbleft.Location = new Point(38, 38);
            lbleft.Name = "lbleft";
            lbleft.Size = new Size(141, 25);
            lbleft.TabIndex = 0;
            lbleft.Text = "Electronics Store";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 859);
            Controls.Add(pnldashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            pnldashboard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlsidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbleft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.Button bntdashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
    }
}