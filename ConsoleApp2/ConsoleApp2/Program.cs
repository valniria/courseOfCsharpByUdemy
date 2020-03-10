using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Params");
            int somatorio = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(somatorio);
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.WriteLine("ref e out");
            int a = 10;
            int result;
            Calculator.Triple(a, out result);
            Console.WriteLine(result);

            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("Foreach");

            string[] vect = new string[] { "Maria", "Bob", "José" };

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
