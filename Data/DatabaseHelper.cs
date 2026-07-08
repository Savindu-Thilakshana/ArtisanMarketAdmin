using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;

namespace ArtisanMarketAdmin.Data
{
    /// <summary>
    /// Encapsulation: every other class talks to the database through this
    /// class only. Nobody else in the project should open a SqliteConnection
    /// or write raw SQL directly - that all lives here.
    /// </summary>
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string dbFileName = "ArtisanMarket.db")
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbFileName);
            _connectionString = $"Data Source={dbPath}";
        }

        private SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection(_connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Call this once when the app starts. Creates the four tables if
        /// they don't already exist, then adds a bit of seed data so the
        /// rest of the team has real records to build their forms against.
        /// </summary>
        public void InitializeDatabase()
        {
            using var connection = GetConnection();

            string createAdmins = @"
                CREATE TABLE IF NOT EXISTS Admins (
                    AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );";

            string createArtisans = @"
                CREATE TABLE IF NOT EXISTS Artisans (
                    ArtisanId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Contact TEXT,
                    Status TEXT NOT NULL DEFAULT 'Pending'
                );";

            string createProducts = @"
                CREATE TABLE IF NOT EXISTS Products (
                    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Stock INTEGER NOT NULL,
                    Category TEXT,
                    ArtisanId INTEGER,
                    FOREIGN KEY (ArtisanId) REFERENCES Artisans(ArtisanId)
                );";

            string createOrders = @"
                CREATE TABLE IF NOT EXISTS Orders (
                    OrderId INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductId INTEGER NOT NULL,
                    Quantity INTEGER NOT NULL,
                    TotalPrice REAL NOT NULL,
                    OrderDate TEXT NOT NULL,
                    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
                );";

            ExecuteNonQuery(connection, createAdmins);
            ExecuteNonQuery(connection, createArtisans);
            ExecuteNonQuery(connection, createProducts);
            ExecuteNonQuery(connection, createOrders);

            SeedTestData(connection);
        }

        private void SeedTestData(SqliteConnection connection)
        {
            using var checkCmd = new SqliteCommand("SELECT COUNT(*) FROM Admins", connection);
            long adminCount = (long)checkCmd.ExecuteScalar();

            if (adminCount == 0)
            {
                ExecuteNonQuery(connection,
                    "INSERT INTO Admins (Username, Password) VALUES ('admin', 'admin123');");

                ExecuteNonQuery(connection,
                    "INSERT INTO Artisans (Name, Email, Contact, Status) VALUES " +
                    "('Nimal Perera', 'nimal@example.com', '0711234567', 'Active')," +
                    "('Kumari Silva', 'kumari@example.com', '0777654321', 'Pending');");

                ExecuteNonQuery(connection,
                    "INSERT INTO Products (Name, Price, Stock, Category, ArtisanId) VALUES " +
                    "('Handwoven Basket', 1500.00, 10, 'Home Decor', 1)," +
                    "('Batik Sarong', 2500.00, 5, 'Clothing', 1);");
            }
        }

        private void ExecuteNonQuery(SqliteConnection connection, string sql,
            Dictionary<string, object> parameters = null)
        {
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, parameters);
            command.ExecuteNonQuery();
        }

        /// <summary>Run an INSERT / UPDATE / DELETE / CREATE statement.</summary>
        public void ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
        {
            using var connection = GetConnection();
            ExecuteNonQuery(connection, sql, parameters);
        }

        /// <summary>Run a SELECT and get the rows back as a list of column-name/value dictionaries.</summary>
        public List<Dictionary<string, object>> ExecuteQuery(string sql,
            Dictionary<string, object> parameters = null)
        {
            var results = new List<Dictionary<string, object>>();
            using var connection = GetConnection();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, parameters);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row[reader.GetName(i)] = reader.GetValue(i);
                results.Add(row);
            }
            return results;
        }

        /// <summary>Run a SELECT that returns a single value, e.g. SELECT COUNT(*).</summary>
        public object ExecuteScalar(string sql, Dictionary<string, object> parameters = null)
        {
            using var connection = GetConnection();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, parameters);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Run a SELECT and get the results back as a DataTable - this is the
        /// one to use when binding straight to a DataGridView, e.g.
        /// dgvItems.DataSource = db.ExecuteQueryToTable("SELECT * FROM Products");
        /// </summary>
        public System.Data.DataTable ExecuteQueryToTable(string sql, Dictionary<string, object> parameters = null)
        {
            var table = new System.Data.DataTable();
            using var connection = GetConnection();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, parameters);

            using var reader = command.ExecuteReader();
            table.Load(reader);
            return table;
        }

        private void AddParameters(SqliteCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null) return;
            foreach (var p in parameters)
                command.Parameters.AddWithValue(p.Key, p.Value);
        }
    }
}