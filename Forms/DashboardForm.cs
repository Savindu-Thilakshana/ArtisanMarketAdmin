using ArtisanMarketAdmin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArtisanMarketAdmin.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            new ItemListForm().ShowDialog();
        }

        private void btnArtisans_Click(object sender, EventArgs e)
        {
            new ArtisanListForm().ShowDialog();
        }

        private void btnPendingApplications_Click(object sender, EventArgs e)
        {
            new PendingApplicationsForm().ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            new SalesReportForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            new RecordSaleForm().ShowDialog();
        }


        private DatabaseHelper _db = new DatabaseHelper();

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblTotalItems.Text = "Items: " + _db.ExecuteScalar("SELECT COUNT(*) FROM Products");
            lblTotalArtisans.Text = "Artisans: " + _db.ExecuteScalar("SELECT COUNT(*) FROM Artisans WHERE Status = 'Active'");
            lblTotalOrders.Text = "Orders: " + _db.ExecuteScalar("SELECT COUNT(*) FROM Orders");
        }

        private void lblTotalItems_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalArtisans_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}