using System;
using System.Globalization;

namespace Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
      
            Produto[] prod = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                soma += prod[i].Preco;
            }

            Console.WriteLine("Aveged height: " + (soma/n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
