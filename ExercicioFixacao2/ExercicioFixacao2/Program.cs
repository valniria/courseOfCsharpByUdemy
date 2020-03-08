using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area = " + retangulo.Area(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal(largura, altura).ToString("F2", CultureInfo.InvariantCulture)
                );
        }
    }
}
