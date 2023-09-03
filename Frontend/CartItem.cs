using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend
{
    public class CartItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public CartItem(string productId, string productName, decimal price, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        // You can add other properties or methods as needed.
    }

}