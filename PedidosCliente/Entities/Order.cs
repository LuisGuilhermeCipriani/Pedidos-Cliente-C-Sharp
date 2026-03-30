using System;
using System.Collections.Generic;
using System.Text;
using PedidosCliente.Entities;

namespace PedidosCliente.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {}

        public Order(DateTime Moment, OrderStatus status, Client client)
        {
            Moment = Moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {

        }
    }
}
