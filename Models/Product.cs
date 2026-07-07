using System;
using System.Collections.Generic;
using ArtisanMarketAdmin.Data;

namespace ArtisanMarketAdmin.Models
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _stock;
        private string _category;

        public int ProductId { get; set; }
        public int ArtisanId { get; set; }

        public Product(int productId, string name, decimal price, int stock, string category, int artisanId)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Stock = stock;
            Category = category;
            ArtisanId = artisanId;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Product name cannot be empty.");
                _name = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock cannot be negative.");
                _stock = value;
            }
        }

        public string Category
        {
            get => _category;
            set => _category = value;
        }

        
        public static void RemoveProduct(DatabaseHelper db, int productId)
        {
            var parameters = new Dictionary<string, object> { { "@id", productId } };
            db.ExecuteNonQuery("DELETE FROM Products WHERE ProductId = @id", parameters);
        }

        
        public static List<Dictionary<string, object>> Search(DatabaseHelper db, string name)
        {
            var parameters = new Dictionary<string, object> { { "@name", $"%{name}%" } };
            return db.ExecuteQuery("SELECT * FROM Products WHERE Name LIKE @name", parameters);
        }

       
        public static List<Dictionary<string, object>> Search(DatabaseHelper db, string name, string category)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@name", $"%{name}%" },
                { "@category", category }
            };
            return db.ExecuteQuery(
                "SELECT * FROM Products WHERE Name LIKE @name AND Category = @category",
                parameters);
        }
    }
}
