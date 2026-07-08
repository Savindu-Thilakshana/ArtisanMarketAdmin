using System;
using System.Windows.Forms;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Forms
{
    public partial class ArtisanListForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public ArtisanListForm()
        {
            InitializeComponent();
        }

        private void ArtisanListForm_Load(object sender, EventArgs e)
        {
            LoadArtisans();
        }

        private void LoadArtisans()
        {
            dgvArtisans.DataSource = _db.ExecuteQueryToTable(
                "SELECT ArtisanId, Name, Email, Contact, Status FROM Artisans WHERE Status = 'Active'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadArtisans();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}