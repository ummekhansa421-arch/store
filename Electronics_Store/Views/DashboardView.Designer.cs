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
            this.tbldashboaedview = new System.Windows.Forms.TableLayoutPanel();
            this.tblkpi = new System.Windows.Forms.TableLayoutPanel();
            this.flpsales = new System.Windows.Forms.Panel();
            this.lbsaleV = new System.Windows.Forms.Label();
            this.lbsale = new System.Windows.Forms.Label();
            this.flporders = new System.Windows.Forms.Panel();
            this.lblorderV = new System.Windows.Forms.Label();
            this.lborders = new System.Windows.Forms.Label();
            this.flprevenue = new System.Windows.Forms.Panel();
            this.lbrevenuV = new System.Windows.Forms.Label();
            this.lbrevenu = new System.Windows.Forms.Label();
            this.pnldgvstock = new System.Windows.Forms.Panel();
            this.listViewLowStock = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pnldgvorders = new System.Windows.Forms.Panel();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stactus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbldashboaedview.SuspendLayout();
            this.tblkpi.SuspendLayout();
            this.flpsales.SuspendLayout();
            this.flporders.SuspendLayout();
            this.flprevenue.SuspendLayout();
            this.pnldgvstock.SuspendLayout();
            this.pnldgvorders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbldashboaedview
            // 
            this.tbldashboaedview.ColumnCount = 1;
            this.tbldashboaedview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbldashboaedview.Controls.Add(this.tblkpi, 0, 0);
            this.tbldashboaedview.Controls.Add(this.pnldgvstock, 0, 1);
            this.tbldashboaedview.Controls.Add(this.pnldgvorders, 0, 2);
            this.tbldashboaedview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbldashboaedview.Location = new System.Drawing.Point(0, 0);
            this.tbldashboaedview.Name = "tbldashboaedview";
            this.tbldashboaedview.RowCount = 3;
            this.tbldashboaedview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tbldashboaedview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboaedview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbldashboaedview.Size = new System.Drawing.Size(1141, 624);
            this.tbldashboaedview.TabIndex = 0;
            // 
            // tblkpi
            // 
            this.tblkpi.ColumnCount = 3;
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.Controls.Add(this.flpsales, 0, 0);
            this.tblkpi.Controls.Add(this.flporders, 1, 0);
            this.tblkpi.Controls.Add(this.flprevenue, 2, 0);
            this.tblkpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblkpi.Location = new System.Drawing.Point(3, 3);
            this.tblkpi.Name = "tblkpi";
            this.tblkpi.RowCount = 1;
            this.tblkpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblkpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tblkpi.Size = new System.Drawing.Size(1135, 154);
            this.tblkpi.TabIndex = 0;
            // 
            // flpsales
            // 
            this.flpsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flpsales.Controls.Add(this.lbsaleV);
            this.flpsales.Controls.Add(this.lbsale);
            this.flpsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpsales.Location = new System.Drawing.Point(5, 5);
            this.flpsales.Margin = new System.Windows.Forms.Padding(5);
            this.flpsales.Name = "flpsales";
            this.flpsales.Size = new System.Drawing.Size(368, 144);
            this.flpsales.TabIndex = 0;
            // 
            // lbsaleV
            // 
            this.lbsaleV.AutoSize = true;
            this.lbsaleV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsaleV.Location = new System.Drawing.Point(273, 57);
            this.lbsaleV.Name = "lbsaleV";
            this.lbsaleV.Size = new System.Drawing.Size(59, 20);
            this.lbsaleV.TabIndex = 1;
            this.lbsaleV.Text = "11111";
            this.lbsaleV.Click += new System.EventHandler(this.lbsaleV_Click);
            // 
            // lbsale
            // 
            this.lbsale.AutoSize = true;
            this.lbsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsale.Location = new System.Drawing.Point(37, 57);
            this.lbsale.Name = "lbsale";
            this.lbsale.Size = new System.Drawing.Size(54, 20);
            this.lbsale.TabIndex = 0;
            this.lbsale.Text = "Sales";
            // 
            // flporders
            // 
            this.flporders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flporders.Controls.Add(this.lblorderV);
            this.flporders.Controls.Add(this.lborders);
            this.flporders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flporders.Location = new System.Drawing.Point(383, 5);
            this.flporders.Margin = new System.Windows.Forms.Padding(5);
            this.flporders.Name = "flporders";
            this.flporders.Size = new System.Drawing.Size(368, 144);
            this.flporders.TabIndex = 1;
            // 
            // lblorderV
            // 
            this.lblorderV.AutoSize = true;
            this.lblorderV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderV.Location = new System.Drawing.Point(295, 57);
            this.lblorderV.Name = "lblorderV";
            this.lblorderV.Size = new System.Drawing.Size(39, 20);
            this.lblorderV.TabIndex = 1;
            this.lblorderV.Text = "100";
            // 
            // lborders
            // 
            this.lborders.AutoSize = true;
            this.lborders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborders.Location = new System.Drawing.Point(47, 57);
            this.lborders.Name = "lborders";
            this.lborders.Size = new System.Drawing.Size(63, 20);
            this.lborders.TabIndex = 0;
            this.lborders.Text = "Orders";
            // 
            // flprevenue
            // 
            this.flprevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flprevenue.Controls.Add(this.lbrevenuV);
            this.flprevenue.Controls.Add(this.lbrevenu);
            this.flprevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flprevenue.Location = new System.Drawing.Point(761, 5);
            this.flprevenue.Margin = new System.Windows.Forms.Padding(5);
            this.flprevenue.Name = "flprevenue";
            this.flprevenue.Size = new System.Drawing.Size(369, 144);
            this.flprevenue.TabIndex = 2;
            // 
            // lbrevenuV
            // 
            this.lbrevenuV.AutoSize = true;
            this.lbrevenuV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrevenuV.Location = new System.Drawing.Point(250, 57);
            this.lbrevenuV.Name = "lbrevenuV";
            this.lbrevenuV.Size = new System.Drawing.Size(103, 20);
            this.lbrevenuV.TabIndex = 1;
            this.lbrevenuV.Text = "1234557 pk";
            // 
            // lbrevenu
            // 
            this.lbrevenu.AutoSize = true;
            this.lbrevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrevenu.Location = new System.Drawing.Point(53, 57);
            this.lbrevenu.Name = "lbrevenu";
            this.lbrevenu.Size = new System.Drawing.Size(80, 20);
            this.lbrevenu.TabIndex = 0;
            this.lbrevenu.Text = "Revenue";
            this.lbrevenu.Click += new System.EventHandler(this.lbrevenu_Click);
            // 
            // pnldgvstock
            // 
            this.pnldgvstock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnldgvstock.Controls.Add(this.listViewLowStock);
            this.pnldgvstock.Controls.Add(this.label1);
            this.pnldgvstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgvstock.Location = new System.Drawing.Point(3, 163);
            this.pnldgvstock.Name = "pnldgvstock";
            this.pnldgvstock.Size = new System.Drawing.Size(1135, 226);
            this.pnldgvstock.TabIndex = 1;
            // 
            // listViewLowStock
            // 
            this.listViewLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLowStock.FullRowSelect = true;
            this.listViewLowStock.GridLines = true;
            this.listViewLowStock.HideSelection = false;
            this.listViewLowStock.Location = new System.Drawing.Point(0, 20);
            this.listViewLowStock.Name = "listViewLowStock";
            this.listViewLowStock.Size = new System.Drawing.Size(1135, 206);
            this.listViewLowStock.TabIndex = 1;
            this.listViewLowStock.UseCompatibleStateImageBehavior = false;
            this.listViewLowStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Stock";
            // 
            // pnldgvorders
            // 
            this.pnldgvorders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnldgvorders.Controls.Add(this.listViewOrders);
            this.pnldgvorders.Controls.Add(this.label2);
            this.pnldgvorders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgvorders.Location = new System.Drawing.Point(3, 395);
            this.pnldgvorders.Name = "pnldgvorders";
            this.pnldgvorders.Size = new System.Drawing.Size(1135, 226);
            this.pnldgvorders.TabIndex = 2;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.stactus});
            this.listViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(0, 20);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(1135, 206);
            this.listViewOrders.TabIndex = 1;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            // 
            // stactus
            // 
            this.stactus.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbldashboaedview);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1141, 624);
            this.tbldashboaedview.ResumeLayout(false);
            this.tblkpi.ResumeLayout(false);
            this.flpsales.ResumeLayout(false);
            this.flpsales.PerformLayout();
            this.flporders.ResumeLayout(false);
            this.flporders.PerformLayout();
            this.flprevenue.ResumeLayout(false);
            this.flprevenue.PerformLayout();
            this.pnldgvstock.ResumeLayout(false);
            this.pnldgvstock.PerformLayout();
            this.pnldgvorders.ResumeLayout(false);
            this.pnldgvorders.PerformLayout();
            this.ResumeLayout(false);

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
