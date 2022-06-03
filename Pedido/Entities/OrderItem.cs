using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() 
        {
        }
        public OrderItem(int quant, double price, Product product)
        {
            Quantity = quant;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
