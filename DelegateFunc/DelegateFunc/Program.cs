using System;
using System.Collections.Generic;
using DelegateFunc.Entities;
using System.Linq;

namespace DelegateFunc
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

            //Comum
            //foreach (Product p in list)
            //{
            //    p.Name = p.Name.ToUpper();
            //}

            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}


            //Selec
            //List<string> result = list.Select(NameUpper).ToList();

            //foreach (String s in result)
            //{
            //    Console.WriteLine(s);
            //}


            //Com Func Delegate
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //foreach (String s in result)
            //{
            //    Console.WriteLine(s);
            //}


            //Com Lambda
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<String> result = list.Select(func).ToList();

            //foreach (String s in result)
            //{
            //    Console.WriteLine(s);
            //}


            //Com Lambda inline
            List<String> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (String s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
