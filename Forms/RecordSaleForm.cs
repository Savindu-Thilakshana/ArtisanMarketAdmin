using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Forms
{
    public partial class RecordSaleForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public RecordSaleForm()
        {
            InitializeComponent();
        }

        private void RecordSaleForm_Load(object sender, EventArgs e)
        {
            var products = _db.ExecuteQueryToTable("SELECT ProductId, Name, Price, Stock FROM Products");
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = ((System.Data.DataRowView)cmbProduct.SelectedItem).Row;
            lblUnitPrice.Text = "Unit Price: " + row["Price"];
            lblStock.Text = "Available Stock: " + row["Stock"];
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((System.Data.DataRowView)cmbProduct.SelectedItem).Row;
                int productId = Convert.ToInt32(row["ProductId"]);
                decimal unitPrice = Convert.ToDecimal(row["Price"]);
                int currentStock = Convert.ToInt32(row["Stock"]);
                int quantity = int.Parse(txtQuantity.Text);

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be at least 1.");
                    return;
                }
                if (quantity > currentStock)
                {
                    MessageBox.Show($"Only {currentStock} in stock - can't sell {quantity}.");
                    return;
                }

                decimal totalPrice = unitPrice * quantity;

                _db.ExecuteNonQuery(
                    "INSERT INTO Orders (ProductId, Quantity, TotalPrice, OrderDate) VALUES (@p, @q, @t, @d)",
                    new Dictionary<string, object>
                    {
                        { "@p", productId }, { "@q", quantity },
                        { "@t", totalPrice }, { "@d", DateTime.Now.ToString("yyyy-MM-dd") }
                    });

                _db.ExecuteNonQuery(
                    "UPDATE Products SET Stock = Stock - @q WHERE ProductId = @p",
                    new Dictionary<string, object> { { "@q", quantity }, { "@p", productId } });

                MessageBox.Show($"Sale recorded: {quantity} x sold for a total of {totalPrice}.");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity must be a whole number.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
