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
            tbldashboaedview = new TableLayoutPanel();
            tblkpi = new TableLayoutPanel();
            flpsales = new Panel();
            lbsaleV = new Label();
            lbsale = new Label();
            flporders = new Panel();
            lblorderV = new Label();
            lborders = new Label();
            flprevenue = new Panel();
            lbrevenuV = new Label();
            lbrevenu = new Label();
            pnldgvstock = new Panel();
            listViewLowStock = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            pnldgvorders = new Panel();
            listViewOrders = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            stactus = new ColumnHeader();
            label2 = new Label();
            tbldashboaedview.SuspendLayout();
            tblkpi.SuspendLayout();
            flpsales.SuspendLayout();
            flporders.SuspendLayout();
            flprevenue.SuspendLayout();
            pnldgvstock.SuspendLayout();
            pnldgvorders.SuspendLayout();
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
            flpsales.BackColor = Color.FromArgb(224, 224, 224);
            flpsales.Controls.Add(lbsaleV);
            flpsales.Controls.Add(lbsale);
            flpsales.Dock = DockStyle.Fill;
            flpsales.Location = new Point(6, 6);
            flpsales.Margin = new Padding(6);
            flpsales.Name = "flpsales";
            flpsales.Size = new Size(408, 180);
            flpsales.TabIndex = 0;
            // 
            // lbsaleV
            // 
            lbsaleV.AutoSize = true;
            lbsaleV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbsaleV.Location = new Point(303, 71);
            lbsaleV.Name = "lbsaleV";
            lbsaleV.Size = new Size(59, 20);
            lbsaleV.TabIndex = 1;
            lbsaleV.Text = "11111";
            lbsaleV.Click += lbsaleV_Click;
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
            flporders.BackColor = Color.FromArgb(224, 224, 224);
            flporders.Controls.Add(lblorderV);
            flporders.Controls.Add(lborders);
            flporders.Dock = DockStyle.Fill;
            flporders.Location = new Point(426, 6);
            flporders.Margin = new Padding(6);
            flporders.Name = "flporders";
            flporders.Size = new Size(408, 180);
            flporders.TabIndex = 1;
            // 
            // lblorderV
            // 
            lblorderV.AutoSize = true;
            lblorderV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblorderV.Location = new Point(328, 71);
            lblorderV.Name = "lblorderV";
            lblorderV.Size = new Size(39, 20);
            lblorderV.TabIndex = 1;
            lblorderV.Text = "100";
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
            flprevenue.BackColor = Color.FromArgb(224, 224, 224);
            flprevenue.Controls.Add(lbrevenuV);
            flprevenue.Controls.Add(lbrevenu);
            flprevenue.Dock = DockStyle.Fill;
            flprevenue.Location = new Point(846, 6);
            flprevenue.Margin = new Padding(6);
            flprevenue.Name = "flprevenue";
            flprevenue.Size = new Size(410, 180);
            flprevenue.TabIndex = 2;
            // 
            // lbrevenuV
            // 
            lbrevenuV.AutoSize = true;
            lbrevenuV.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbrevenuV.Location = new Point(278, 71);
            lbrevenuV.Name = "lbrevenuV";
            lbrevenuV.Size = new Size(103, 20);
            lbrevenuV.TabIndex = 1;
            lbrevenuV.Text = "1234557 pk";
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
            pnldgvstock.Controls.Add(listViewLowStock);
            pnldgvstock.Controls.Add(label1);
            pnldgvstock.Dock = DockStyle.Fill;
            pnldgvstock.Location = new Point(3, 204);
            pnldgvstock.Margin = new Padding(3, 4, 3, 4);
            pnldgvstock.Name = "pnldgvstock";
            pnldgvstock.Size = new Size(1262, 282);
            pnldgvstock.TabIndex = 1;
            // 
            // listViewLowStock
            // 
            listViewLowStock.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewLowStock.Dock = DockStyle.Fill;
            listViewLowStock.FullRowSelect = true;
            listViewLowStock.GridLines = true;
            listViewLowStock.Location = new Point(0, 20);
            listViewLowStock.Margin = new Padding(3, 4, 3, 4);
            listViewLowStock.Name = "listViewLowStock";
            listViewLowStock.Size = new Size(1262, 262);
            listViewLowStock.TabIndex = 1;
            listViewLowStock.UseCompatibleStateImageBehavior = false;
            listViewLowStock.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Product";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Stock";
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
            pnldgvorders.Controls.Add(listViewOrders);
            pnldgvorders.Controls.Add(label2);
            pnldgvorders.Dock = DockStyle.Fill;
            pnldgvorders.Location = new Point(3, 494);
            pnldgvorders.Margin = new Padding(3, 4, 3, 4);
            pnldgvorders.Name = "pnldgvorders";
            pnldgvorders.Size = new Size(1262, 282);
            pnldgvorders.TabIndex = 2;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, stactus });
            listViewOrders.Dock = DockStyle.Fill;
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(0, 20);
            listViewOrders.Margin = new Padding(3, 4, 3, 4);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(1262, 262);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Customer";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Product";
            // 
            // stactus
            // 
            stactus.Text = "Status";
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
            pnldgvorders.ResumeLayout(false);
            pnldgvorders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbldashboaedview;
        private System.Windows.Forms.TableLayoutPanel tblkpi;
        private System.Windows.Forms.Panel flpsales;
        private System.Windows.Forms.Panel flporders;
        private System.Windows.Forms.Panel flprevenue;
        private System.Windows.Forms.Label lbsaleV;
        private System.Windows.Forms.Label lbsale;
        private System.Windows.Forms.Label lblorderV;
        private System.Windows.Forms.Label lborders;
        private System.Windows.Forms.Label lbrevenuV;
        private System.Windows.Forms.Label lbrevenu;
        private System.Windows.Forms.Panel pnldgvstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnldgvorders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewLowStock;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader stactus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
