
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade do vetor");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i=0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            Console.WriteLine("Average height: " + (sum/n).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
