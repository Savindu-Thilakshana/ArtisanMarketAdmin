using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArtisanMarketAdmin.Forms
{
    public partial class EditItemForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private readonly int _productId;

        public EditItemForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            
            var artisans = _db.ExecuteQueryToTable("SELECT ArtisanId, Name FROM Artisans WHERE Status = 'Active'");
            cmbArtisan.DataSource = artisans;
            cmbArtisan.DisplayMember = "Name";
            cmbArtisan.ValueMember = "ArtisanId";

            
            var table = _db.ExecuteQueryToTable(
                "SELECT * FROM Products WHERE ProductId = @id",
                new Dictionary<string, object> { { "@id", _productId } });

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Item not found.");
                this.Close();
                return;
            }

            var row = table.Rows[0];
            txtName.Text = row["Name"].ToString();
            txtPrice.Text = row["Price"].ToString();
            txtStock.Text = row["Stock"].ToString();
            cmbCategory.Text = row["Category"].ToString();
            cmbArtisan.SelectedValue = row["ArtisanId"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(
                    _productId,
                    txtName.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtStock.Text),
                    cmbCategory.Text,
                    Convert.ToInt32(cmbArtisan.SelectedValue));

                _db.ExecuteNonQuery(
                    "UPDATE Products SET Name=@n, Price=@p, Stock=@s, Category=@c, ArtisanId=@a WHERE ProductId=@id",
                    new Dictionary<string, object>
                    {
                        { "@n", product.Name }, { "@p", product.Price }, { "@s", product.Stock },
                        { "@c", product.Category }, { "@a", product.ArtisanId }, { "@id", _productId }
                    });

                MessageBox.Show("Item updated successfully.");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Price and Stock must be valid numbers.");
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