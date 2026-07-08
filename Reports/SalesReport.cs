using System.Collections.Generic;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Reports
{
   
    public class SalesReport : Report
    {
        public SalesReport(DatabaseHelper db) : base(db) { }

        public override List<Dictionary<string, object>> GenerateReport()
        {
            string sql = @"
                SELECT p.Name AS ProductName,
                       SUM(o.Quantity) AS TotalQuantitySold,
                       SUM(o.TotalPrice) AS TotalRevenue
                FROM Orders o
                JOIN Products p ON o.ProductId = p.ProductId
                GROUP BY p.Name
                ORDER BY TotalRevenue DESC;";

            return Db.ExecuteQuery(sql);
        }
    }
}