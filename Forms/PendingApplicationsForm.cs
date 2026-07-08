using System;
using System.Windows.Forms;
using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;

namespace ArtisanMarketAdmin.Forms
{
    public partial class PendingApplicationsForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public PendingApplicationsForm()
        {
            InitializeComponent();
        }

        private void PendingApplicationsForm_Load(object sender, EventArgs e)
        {
            LoadPending();
        }

        private void LoadPending()
        {
            dgvPending.DataSource = _db.ExecuteQueryToTable(
                "SELECT ArtisanId, Name, Email, Contact FROM Artisans WHERE Status = 'Pending'");
        }

        private void btnApprove_Click(object sender, EventArgs e) => ProcessSelected(approve: true);
        private void btnReject_Click(object sender, EventArgs e) => ProcessSelected(approve: false);
        private void btnRegisterNew_Click(object sender, EventArgs e)
        {
            new AddArtisanForm().ShowDialog();
            LoadPending(); 
        }

        private void ProcessSelected(bool approve)
        {
            if (dgvPending.CurrentRow == null)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            int id = Convert.ToInt32(dgvPending.CurrentRow.Cells["ArtisanId"].Value);
            string name = dgvPending.CurrentRow.Cells["Name"].Value.ToString();
            string email = dgvPending.CurrentRow.Cells["Email"].Value.ToString();
            string contact = dgvPending.CurrentRow.Cells["Contact"].Value?.ToString();

            var applicant = new PendingArtisan(id, name, email, contact);
            if (approve) applicant.Approve(); else applicant.Reject();

            _db.ExecuteNonQuery(
                "UPDATE Artisans SET Status = @s WHERE ArtisanId = @id",
                new System.Collections.Generic.Dictionary<string, object>
                {
                    { "@s", applicant.GetCurrentStatus() },
                    { "@id", id }
                });

            LoadPending();
        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {

        }
    }
}