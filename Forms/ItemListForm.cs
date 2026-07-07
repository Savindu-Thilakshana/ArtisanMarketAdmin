using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;

namespace ArtisanMarketAdmin.Forms
{
    public partial class ItemListForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public ItemListForm()
        {
            InitializeComponent();
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        }

        private void ItemListForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            dgvItems.DataSource = _db.ExecuteQueryToTable("SELECT * FROM Products");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;

            dgvItems.DataSource = _db.ExecuteQueryToTable(
            "SELECT * FROM Products WHERE Name LIKE @n",
            new Dictionary<string, object> { { "@n", $"%{name}%" } });

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            int id = Convert.ToInt32(dgvItems.CurrentRow.Cells["ProductId"].Value);

            if (MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Product.RemoveProduct(_db, id);
                LoadItems();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new AddItemForm().ShowDialog();
            LoadItems();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            int id = Convert.ToInt32(dgvItems.CurrentRow.Cells["ProductId"].Value);
            new EditItemForm(id).ShowDialog();
            LoadItems();
        }
    }
}
