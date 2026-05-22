namespace Electronics_Store.Views
{
    partial class DashboardView
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
            components = new System.ComponentModel.Container();
            tbldashboaedview = new TableLayoutPanel();
            tblkpi = new TableLayoutPanel();
            flpsales = new Panel();
            lblSales = new Label();
            lbsale = new Label();
            flporders = new Panel();
            lblOrders = new Label();
            lborders = new Label();
            flprevenue = new Panel();
            lblRevenue = new Label();
            lbrevenu = new Label();
            pnldgvstock = new Panel();
            dgvLowStock = new DataGridView();
            label1 = new Label();
            pnldgvorders = new Panel();
            dgvRecentOrders = new DataGridView();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            tbldashboaedview.SuspendLayout();
            tblkpi.SuspendLayout();
            flpsales.SuspendLayout();
            flporders.SuspendLayout();
            flprevenue.SuspendLayout();
            pnldgvstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            pnldgvorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            SuspendLayout();
            // 
            // tbldashboaedview
            // 
            tbldashboaedview.ColumnCount = 1;
            tbldashboaedview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbldashboaedview.Controls.Add(tblkpi, 0, 0);
            tbldashboaedview.Controls.Add(pnldgvstock, 0, 1);
            tbldashboaedview.Controls.Add(pnldgvorders, 0, 2);
            tbldashboaedview.Dock = DockStyle.Fill;
            tbldashboaedview.Location = new Point(0, 0);
            tbldashboaedview.Margin = new Padding(3, 4, 3, 4);
            tbldashboaedview.Name = "tbldashboaedview";
            tbldashboaedview.RowCount = 3;
            tbldashboaedview.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tbldashboaedview.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbldashboaedview.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbldashboaedview.Size = new Size(1268, 780);
            tbldashboaedview.TabIndex = 0;
            // 
            // tblkpi
            // 
            tblkpi.ColumnCount = 3;
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblkpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblkpi.Controls.Add(flpsales, 0, 0);
            tblkpi.Controls.Add(flporders, 1, 0);
            tblkpi.Controls.Add(flprevenue, 2, 0);
            tblkpi.Dock = DockStyle.Fill;
            tblkpi.Location = new Point(3, 4);
            tblkpi.Margin = new Padding(3, 4, 3, 4);
            tblkpi.Name = "tblkpi";
            tblkpi.RowCount = 1;
            tblkpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblkpi.RowStyles.Add(new RowStyle(SizeType.Absolute, 192F));
            tblkpi.Size = new Size(1262, 192);
            tblkpi.TabIndex = 0;
            // 
            // flpsales
            // 
            flpsales.BackColor = Color.WhiteSmoke;
            flpsales.Controls.Add(lblSales);
            flpsales.Controls.Add(lbsale);
            flpsales.Dock = DockStyle.Fill;
            flpsales.Location = new Point(6, 6);
            flpsales.Margin = new Padding(6);
            flpsales.Name = "flpsales";
            flpsales.Size = new Size(408, 180);
            flpsales.TabIndex = 0;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(303, 71);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(59, 20);
            lblSales.TabIndex = 1;
            lblSales.Text = "11111";
            lblSales.Click += lbsaleV_Click;
            // 
            // lbsale
            // 
            lbsale.AutoSize = true;
            lbsale.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbsale.Location = new Point(41, 71);
            lbsale.Name = "lbsale";
            lbsale.Size = new Size(54, 20);
            lbsale.TabIndex = 0;
            lbsale.Text = "Sales";
            // 
            // flporders
            // 
            flporders.BackColor = Color.WhiteSmoke;
            flporders.Controls.Add(lblOrders);
            flporders.Controls.Add(lborders);
            flporders.Dock = DockStyle.Fill;
            flporders.Location = new Point(426, 6);
            flporders.Margin = new Padding(6);
            flporders.Name = "flporders";
            flporders.Size = new Size(408, 180);
            flporders.TabIndex = 1;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrders.Location = new Point(328, 71);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(39, 20);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "100";
            // 
            // lborders
            // 
            lborders.AutoSize = true;
            lborders.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lborders.Location = new Point(52, 71);
            lborders.Name = "lborders";
            lborders.Size = new Size(63, 20);
            lborders.TabIndex = 0;
            lborders.Text = "Orders";
            // 
            // flprevenue
            // 
            flprevenue.BackColor = Color.WhiteSmoke;
            flprevenue.Controls.Add(lblRevenue);
            flprevenue.Controls.Add(lbrevenu);
            flprevenue.Dock = DockStyle.Fill;
            flprevenue.Location = new Point(846, 6);
            flprevenue.Margin = new Padding(6);
            flprevenue.Name = "flprevenue";
            flprevenue.Size = new Size(410, 180);
            flprevenue.TabIndex = 2;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.Location = new Point(278, 71);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(103, 20);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "1234557 pk";
            // 
            // lbrevenu
            // 
            lbrevenu.AutoSize = true;
            lbrevenu.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbrevenu.Location = new Point(59, 71);
            lbrevenu.Name = "lbrevenu";
            lbrevenu.Size = new Size(80, 20);
            lbrevenu.TabIndex = 0;
            lbrevenu.Text = "Revenue";
            lbrevenu.Click += lbrevenu_Click;
            // 
            // pnldgvstock
            // 
            pnldgvstock.BackColor = Color.WhiteSmoke;
            pnldgvstock.Controls.Add(dgvLowStock);
            pnldgvstock.Controls.Add(label1);
            pnldgvstock.Dock = DockStyle.Fill;
            pnldgvstock.Location = new Point(3, 204);
            pnldgvstock.Margin = new Padding(3, 4, 3, 4);
            pnldgvstock.Name = "pnldgvstock";
            pnldgvstock.Size = new Size(1262, 282);
            pnldgvstock.TabIndex = 1;
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(0, 20);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.RowHeadersWidth = 62;
            dgvLowStock.Size = new Size(1262, 262);
            dgvLowStock.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Low Stock";
            // 
            // pnldgvorders
            // 
            pnldgvorders.BackColor = Color.WhiteSmoke;
            pnldgvorders.Controls.Add(dgvRecentOrders);
            pnldgvorders.Controls.Add(label2);
            pnldgvorders.Dock = DockStyle.Fill;
            pnldgvorders.Location = new Point(3, 494);
            pnldgvorders.Margin = new Padding(3, 4, 3, 4);
            pnldgvorders.Name = "pnldgvorders";
            pnldgvorders.Size = new Size(1262, 282);
            pnldgvorders.TabIndex = 2;
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentOrders.Dock = DockStyle.Fill;
            dgvRecentOrders.Location = new Point(0, 20);
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.RowHeadersWidth = 62;
            dgvRecentOrders.Size = new Size(1262, 262);
            dgvRecentOrders.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Recent Orders";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 2000;
            timer2.Tick += timer2_Tick;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbldashboaedview);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(1268, 780);
            tbldashboaedview.ResumeLayout(false);
            tblkpi.ResumeLayout(false);
            flpsales.ResumeLayout(false);
            flpsales.PerformLayout();
            flporders.ResumeLayout(false);
            flporders.PerformLayout();
            flprevenue.ResumeLayout(false);
            flprevenue.PerformLayout();
            pnldgvstock.ResumeLayout(false);
            pnldgvstock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            pnldgvorders.ResumeLayout(false);
            pnldgvorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbldashboaedview;
        private System.Windows.Forms.TableLayoutPanel tblkpi;
        private System.Windows.Forms.Panel flpsales;
        private System.Windows.Forms.Panel flporders;
        private System.Windows.Forms.Panel flprevenue;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lbsale;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lborders;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lbrevenu;
        private System.Windows.Forms.Panel pnldgvstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnldgvorders;
        private System.Windows.Forms.Label label2;
        private DataGridView dgvLowStock;
        private DataGridView dgvRecentOrders;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
