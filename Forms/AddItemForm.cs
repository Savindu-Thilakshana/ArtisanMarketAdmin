using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArtisanMarketAdmin.Forms
{
    public partial class AddItemForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            var artisans = _db.ExecuteQueryToTable("SELECT ArtisanId, Name FROM Artisans WHERE Status = 'Active'");
            cmbArtisan.DataSource = artisans;
            cmbArtisan.DisplayMember = "Name";     
            cmbArtisan.ValueMember = "ArtisanId";  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(
                    productId: 0,
                    name: txtName.Text,
                    price: decimal.Parse(txtPrice.Text),
                    stock: int.Parse(txtStock.Text),
                    category: cmbCategory.Text,
                    artisanId: Convert.ToInt32(cmbArtisan.SelectedValue));

                _db.ExecuteNonQuery(
                    "INSERT INTO Products (Name, Price, Stock, Category, ArtisanId) VALUES (@n, @p, @s, @c, @a)",
                    new Dictionary<string, object>
                    {
                        { "@n", product.Name }, { "@p", product.Price },
                        { "@s", product.Stock }, { "@c", product.Category }, { "@a", product.ArtisanId }
                    });

                MessageBox.Show("Item added successfully.");
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