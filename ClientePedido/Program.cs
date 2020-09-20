using ClientePedido.Entities;
using ClientePedido.Entities.Enums;
using System;
using System.Globalization;

namespace ClientePedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //instanciado um objetos client e order
            Cliente cliente = new Cliente(clientName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                //instanciando objetos e add
                Product product = new Product(name, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}
