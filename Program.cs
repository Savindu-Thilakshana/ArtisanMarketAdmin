using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Forms;

namespace ArtisanMarketAdmin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var db = new DatabaseHelper();
            db.InitializeDatabase();

            Application.Run(new LoginForm());
        }
    }
}