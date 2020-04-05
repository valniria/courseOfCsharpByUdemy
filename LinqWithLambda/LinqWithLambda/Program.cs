using System;
using LinqWithLambda.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("Show Products where Tier 1 and Price < 900.00", r1);

            // var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Show only Name of Products from Tools", r2);

            //var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name }; 
            Print("Show Product where the inicial caracter is a 'C' And anonymous object", r3);

            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("Show Products where Tier = 1 order by Price then by name", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = 
                (from p in r4
                select p)
                .Skip(2)
                .Take(4);
            Print("Show Products where Tier = 1 order by Price then by name AND skip 2 and take 4", r5);

            //var r6 = products.FirstOrDefault();
            var r6 = 
                (from p in products select p)
                .FirstOrDefault();
            Console.WriteLine("First of Products: " + r6);

            //var r7 = products.Where(x => x.Price > 3000.0).FirstOrDefault();
            var r7 = 
                (from p in products
                 where p.Price > 3000.0
                 select p)
                 .FirstOrDefault();
            Console.WriteLine("First or default of Price more than 3000.0" + r7);
            Console.WriteLine();

            var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default teste 1: " + r8);

            var r9 = products.Where(x => x.Id > 30).SingleOrDefault();
            Console.WriteLine("Single or default teste 2: " + r9);

            var r10 = products.Max(x => x.Price);
            Console.WriteLine("Max Price: " + r10);

            var r11 = products.Min(x => x.Price);
            Console.WriteLine("Max Price: " + r11);

            var r12 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 Sum Prices: " + r12);

            var r13 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Average Prices: " + r13);

            var r14 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.00).Average();
            Console.WriteLine("Category 5 Average Prices: " + r14);

            var r15 = products.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Select with Aggregate: " + r15);

            //var r16 = products.GroupBy(x => x.Category);
            var r16 =
                from p in products
                group p by p.Category;
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine();
                Console.WriteLine("Category: " + group.Key.Name + ":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
            }
        }
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}
