using System;
using System.Collections.Generic;
using DelegateAction.Entities;

namespace DelegateAction
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

            //Formas de utilizar o Action com o ForEach
            //list.ForEach(UpdatePrice);

            //Action<Product> action = UpdatePrice;

            //Action<Product> action = p => { p.Price += p.Price * 0.1;  }; //com expressão lambda

            //list.ForEach(action);

            list.ForEach(p => p.Price += p.Price * 0.1);//com expressap lambda inline

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
    }
}
