using System;
using System.Globalization;

namespace ExercicioFixacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago: " + ConversorDeMoeda.CalcularValorASerPago(cotacaoDoDolar, quantidadeDeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
