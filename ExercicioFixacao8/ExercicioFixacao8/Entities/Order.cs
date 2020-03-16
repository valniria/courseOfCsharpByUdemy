using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacao8.Entities.Enums;
using System.Globalization;

namespace ExercicioFixacao8.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Clients { get; set; }
        public List<Product> Products { get; set; }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Clients = client;
        }

        public void addItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void removeItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public double total()
        {
            double sum = 0;

            foreach(OrderItem itens in OrderItems)
            {
                sum += itens.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Clients.ToString());
            sb.AppendLine("Order Itens: ");
            
            foreach(OrderItem itens in OrderItems)
            {
                sb.AppendLine(itens.ToString());
            }

            sb.Append("Total price: $");
            sb.AppendLine(total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
