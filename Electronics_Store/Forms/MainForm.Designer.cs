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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnBillings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lbleft = new System.Windows.Forms.Label();
            this.pnldashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldashboard
            // 
            this.pnldashboard.Controls.Add(this.panel3);
            this.pnldashboard.Controls.Add(this.panel2);
            this.pnldashboard.Controls.Add(this.panel1);
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(0, 0);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(1078, 687);
            this.pnldashboard.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 587);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReports);
            this.panel3.Controls.Add(this.btnBillings);
            this.panel3.Controls.Add(this.btnEmployees);
            this.panel3.Controls.Add(this.btnSales);
            this.panel3.Controls.Add(this.btnCustomer);
            this.panel3.Controls.Add(this.btnProducts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 587);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(38, 17);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 50);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(38, 89);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(120, 50);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(38, 224);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(120, 50);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(38, 292);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 50);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnBillings
            // 
            this.btnBillings.Location = new System.Drawing.Point(38, 158);
            this.btnBillings.Name = "btnBillings";
            this.btnBillings.Size = new System.Drawing.Size(120, 50);
            this.btnBillings.TabIndex = 4;
            this.btnBillings.Text = "Billings";
            this.btnBillings.UseVisualStyleBackColor = true;
            this.btnBillings.Click += new System.EventHandler(this.btnBillings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(38, 362);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 50);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBillings;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lbleft;
    }
}