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
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.bntdashboard = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBillings = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbleft = new System.Windows.Forms.Label();
            this.pnldashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlsidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldashboard
            // 
            this.pnldashboard.Controls.Add(this.panel2);
            this.pnldashboard.Controls.Add(this.panel1);
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(0, 0);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(1078, 687);
            this.pnldashboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlContainer);
            this.panel2.Controls.Add(this.pnlsidebar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 587);
            this.panel2.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(200, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(878, 587);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.Controls.Add(this.bntdashboard);
            this.pnlsidebar.Controls.Add(this.btnReports);
            this.pnlsidebar.Controls.Add(this.btnBillings);
            this.pnlsidebar.Controls.Add(this.btnEmployees);
            this.pnlsidebar.Controls.Add(this.btnSales);
            this.pnlsidebar.Controls.Add(this.btnCustomers);
            this.pnlsidebar.Controls.Add(this.btnProducts);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(200, 587);
            this.pnlsidebar.TabIndex = 0;
            // 
            // bntdashboard
            // 
            this.bntdashboard.Location = new System.Drawing.Point(40, 30);
            this.bntdashboard.Name = "bntdashboard";
            this.bntdashboard.Size = new System.Drawing.Size(120, 50);
            this.bntdashboard.TabIndex = 13;
            this.bntdashboard.Text = "Dashboard";
            this.bntdashboard.UseVisualStyleBackColor = true;
            this.bntdashboard.Click += new System.EventHandler(this.bntdashboard_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(40, 442);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 50);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnBillings
            // 
            this.btnBillings.Location = new System.Drawing.Point(40, 238);
            this.btnBillings.Name = "btnBillings";
            this.btnBillings.Size = new System.Drawing.Size(120, 50);
            this.btnBillings.TabIndex = 11;
            this.btnBillings.Text = "Billings";
            this.btnBillings.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(40, 372);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 50);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(40, 304);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(120, 50);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(40, 169);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 50);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(40, 97);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 50);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbleft
            // 
            this.lbleft.AutoSize = true;
            this.lbleft.Location = new System.Drawing.Point(34, 30);
            this.lbleft.Name = "lbleft";
            this.lbleft.Size = new System.Drawing.Size(130, 20);
            this.lbleft.TabIndex = 0;
            this.lbleft.Text = "Electronics Store";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 687);
            this.Controls.Add(this.pnldashboard);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnldashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlsidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnBillings;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
    }
}