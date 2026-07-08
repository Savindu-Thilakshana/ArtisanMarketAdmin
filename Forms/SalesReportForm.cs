using System;
using System.Data;
using System.Windows.Forms;
using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Reports;

namespace ArtisanMarketAdmin.Forms
{
    public partial class SalesReportForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            Report report = new SalesReport(_db);
            var results = report.GenerateReport();

            var table = new DataTable();

            if (results.Count == 0)
            {
                MessageBox.Show("No sales data yet - add some Orders to see a report.");
                dgvReport.DataSource = null;
                return;
            }

            foreach (var key in results[0].Keys)
                table.Columns.Add(key);

            foreach (var row in results)
            {
                var dr = table.NewRow();
                foreach (var key in row.Keys)
                    dr[key] = row[key] ?? DBNull.Value;
                table.Rows.Add(dr);
            }

            dgvReport.DataSource = table;
        }
    }
}