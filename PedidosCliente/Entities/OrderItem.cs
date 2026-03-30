using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace PedidosCliente.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {}

        public OrderItem(int quantity, double price, ProductHeaderValue product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {

        }
    }
}
