using System;

namespace ArtisanMarketAdmin.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, int productId, int quantity, decimal totalPrice, DateTime orderDate)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
        }
    }
}
