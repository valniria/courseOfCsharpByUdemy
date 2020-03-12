using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(0, "Valniria");


            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);
            Console.WriteLine("-------------------");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);
            Console.WriteLine("-------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição da lista: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição da lista: " + pos2);
            Console.WriteLine("-------------------");
            List<string> list2 = list.FindAll(x => x.Length == 3);
            Console.WriteLine("-------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(1, 2);
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
