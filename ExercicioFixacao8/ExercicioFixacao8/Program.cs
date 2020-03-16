using System;
using ExercicioFixacao8.Entities.Enums;
using ExercicioFixacao8.Entities;
using System.Globalization;

namespace ExercicioFixacao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Bith date(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order date:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(qnt, productPrice, product);

                order.addItem(orderItem);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}
