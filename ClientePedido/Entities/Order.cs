using ClientePedido.Entities.Enums;
using ClientePedido.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ClientePedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nODER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Cliente.Name} {Cliente.BirthDate.ToString("dd/MM/yyyy")} - {Cliente.Email}");
            sb.AppendLine($"Order status: {Status}");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}," +
                    $" ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}," +
                    $" Quantity: {item.Quantity}," +
                    $" Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
