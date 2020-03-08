using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double numero = 3.0;
            double teste = Math.Pow(numero, 3.0);


            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2")); //concatenação
            Console.WriteLine($"{produto2}, cujo preço é $  {preco2.ToString("F2")}"); //interpolação
            Console.WriteLine("Registro:  {0} anos de idade, código  {1}  e genero  {2}", idade, codigo, genero); //placeholder
        }
    }
}
