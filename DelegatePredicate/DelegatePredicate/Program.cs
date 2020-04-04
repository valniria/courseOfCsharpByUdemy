using System;
using DelegatePredicate.Entities;
using System.Collections.Generic;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(RemoveProductWithPriceMoreOrEqualThanThousand);

            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool RemoveProductWithPriceMoreOrEqualThanThousand(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}
