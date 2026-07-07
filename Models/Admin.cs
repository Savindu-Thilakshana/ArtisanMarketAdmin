using System.Collections.Generic;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Models
{
    public class Admin
    {
        private readonly string _username;
        private readonly string _password;

        public Admin(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public bool Login(DatabaseHelper db)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@username", _username },
                { "@password", _password }
            };

            var results = db.ExecuteQuery(
                "SELECT * FROM Admins WHERE Username = @username AND Password = @password",
                parameters);

            return results.Count > 0;
        }
    }
}