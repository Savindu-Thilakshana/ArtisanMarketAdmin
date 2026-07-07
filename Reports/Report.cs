using System.Collections.Generic;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Reports
{
   
    public class Report
    {
        protected DatabaseHelper Db;

        public Report(DatabaseHelper db)
        {
            Db = db;
        }

        public virtual List<Dictionary<string, object>> GenerateReport()
        {
            
            return new List<Dictionary<string, object>>();
        }
    }
}