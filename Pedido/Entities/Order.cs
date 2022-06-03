using System;
using Pedido.Entities.Enuns;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            orderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            orderItem.Remove(item);
        }
        public double Total()
        {
            double sum =0;
            foreach (OrderItem item in orderItem)
            {
                sum += item.Price * item.Quantity;
            }
            return sum ;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Summary(Resumo de pedidos)");
            sb.AppendLine("Order Moment(Momento do Pedido:) " + Moment);
            sb.AppendLine("Order status (Status:)" + Status);
            sb.AppendLine("Client : " + Client.Name + "  (" + Client.BirthDate + ")  -" + Client.Email );
            sb.AppendLine("Order Items( Itens pedidos :)  ");
            foreach (OrderItem item in orderItem)
            {
                sb.Append(item.Product.Name);
                sb.Append(", " + item.Price);
                sb.Append(", " + item.Quantity);
                sb.AppendLine(", subTotal: " + item.SubTotal());
            }
            sb.AppendLine("Total : $" + Total());
            return sb.ToString();
        }

    }
}
