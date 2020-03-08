using System;
using System.Globalization;

namespace RepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                Console.WriteLine("A raíz desse número é: " + Math.Sqrt(numero).ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Numero Negativo!");
        }
    }
}
