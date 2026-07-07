using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArtisanMarketAdmin.Forms
{
    public partial class AddArtisanForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AddArtisanForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                var applicant = new PendingArtisan(0, txtName.Text, txtEmail.Text, txtContact.Text);

                _db.ExecuteNonQuery(
                    "INSERT INTO Artisans (Name, Email, Contact, Status) VALUES (@n, @e, @c, @s)",
                    new Dictionary<string, object>
                    {
                        { "@n", txtName.Text },
                        { "@e", txtEmail.Text },
                        { "@c", txtContact.Text },
                        { "@s", applicant.ApprovalStatus } 
                    });

                MessageBox.Show("Artisan registered - now awaiting approval.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}