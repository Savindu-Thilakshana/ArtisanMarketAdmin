namespace ArtisanMarketAdmin.Forms
{
    partial class DashboardForm
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            lblTotalItems = new Label();
            lblTotalArtisans = new Label();
            lblTotalOrders = new Label();
            btnManageItems = new Button();
            btnArtisans = new Button();
            btnPendingApplications = new Button();
            btnSalesReport = new Button();
            btnLogout = new Button();
            btnRecordSale = new Button();
            SuspendLayout();
            // 
            // lblTotalItems
            // 
            lblTotalItems.Anchor = AnchorStyles.Top;
            lblTotalItems.AutoSize = true;
            lblTotalItems.BackColor = Color.FromArgb(241, 228, 210);
            lblTotalItems.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItems.Location = new Point(351, 18);
            lblTotalItems.Margin = new Padding(0);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.RightToLeft = RightToLeft.Yes;
            lblTotalItems.Size = new Size(110, 34);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "Items: 0";
            lblTotalItems.Click += lblTotalItems_Click;
            // 
            // lblTotalArtisans
            // 
            lblTotalArtisans.Anchor = AnchorStyles.Top;
            lblTotalArtisans.AutoSize = true;
            lblTotalArtisans.BackColor = Color.FromArgb(243, 220, 210);
            lblTotalArtisans.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold);
            lblTotalArtisans.Location = new Point(519, 18);
            lblTotalArtisans.Margin = new Padding(0);
            lblTotalArtisans.Name = "lblTotalArtisans";
            lblTotalArtisans.RightToLeft = RightToLeft.Yes;
            lblTotalArtisans.Size = new Size(150, 34);
            lblTotalArtisans.TabIndex = 1;
            lblTotalArtisans.Text = "Artisans: 0 ";
            lblTotalArtisans.Click += lblTotalArtisans_Click;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.Anchor = AnchorStyles.Top;
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.BackColor = Color.FromArgb(220, 234, 224);
            lblTotalOrders.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold);
            lblTotalOrders.Location = new Point(736, 18);
            lblTotalOrders.Margin = new Padding(0);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.RightToLeft = RightToLeft.Yes;
            lblTotalOrders.Size = new Size(121, 34);
            lblTotalOrders.TabIndex = 2;
            lblTotalOrders.Text = "Orders: 0";
            lblTotalOrders.Click += lblTotalOrders_Click;
            // 
            // btnManageItems
            // 
            btnManageItems.AutoSize = true;
            btnManageItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageItems.Location = new Point(19, 168);
            btnManageItems.Margin = new Padding(10);
            btnManageItems.Name = "btnManageItems";
            btnManageItems.Size = new Size(222, 74);
            btnManageItems.TabIndex = 3;
            btnManageItems.Text = "Manage Items";
            btnManageItems.UseVisualStyleBackColor = true;
            btnManageItems.Click += btnManageItems_Click;
            // 
            // btnArtisans
            // 
            btnArtisans.AutoSize = true;
            btnArtisans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArtisans.Location = new Point(19, 262);
            btnArtisans.Margin = new Padding(10);
            btnArtisans.Name = "btnArtisans";
            btnArtisans.Size = new Size(222, 74);
            btnArtisans.TabIndex = 4;
            btnArtisans.Text = "View Artisans";
            btnArtisans.UseVisualStyleBackColor = true;
            btnArtisans.Click += btnArtisans_Click;
            // 
            // btnPendingApplications
            // 
            btnPendingApplications.AutoSize = true;
            btnPendingApplications.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingApplications.Location = new Point(19, 356);
            btnPendingApplications.Margin = new Padding(10);
            btnPendingApplications.Name = "btnPendingApplications";
            btnPendingApplications.Size = new Size(222, 74);
            btnPendingApplications.TabIndex = 5;
            btnPendingApplications.Text = "Pending Applications";
            btnPendingApplications.UseVisualStyleBackColor = true;
            btnPendingApplications.Click += btnPendingApplications_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.AutoSize = true;
            btnSalesReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.Location = new Point(19, 544);
            btnSalesReport.Margin = new Padding(10);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(222, 74);
            btnSalesReport.TabIndex = 6;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(220, 234, 224);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.ForeColor = Color.FromArgb(37, 68, 53);
            btnLogout.Location = new Point(1126, 646);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(124, 55);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRecordSale
            // 
            btnRecordSale.AutoSize = true;
            btnRecordSale.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordSale.Location = new Point(19, 450);
            btnRecordSale.Margin = new Padding(10);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(222, 74);
            btnRecordSale.TabIndex = 8;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.dashboard_background;
            ClientSize = new Size(1251, 704);
            Controls.Add(btnLogout);
            Controls.Add(btnManageItems);
            Controls.Add(btnSalesReport);
            Controls.Add(btnRecordSale);
            Controls.Add(btnPendingApplications);
            Controls.Add(btnArtisans);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalItems);
            Controls.Add(lblTotalArtisans);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Artisan Market Admin";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalItems;
        private Label lblTotalArtisans;
        private Label lblTotalOrders;
        private Button btnManageItems;
        private Button btnArtisans;
        private Button btnPendingApplications;
        private Button btnSalesReport;
        private Button btnLogout;
        private Button btnRecordSale;
    }
}