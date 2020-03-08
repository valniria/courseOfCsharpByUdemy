using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write ("Bom dia");
            Console.WriteLine("Boa tarde!");

            Console.WriteLine(genero);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeholder


            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "+ saldo.ToString("F2", CultureInfo.InvariantCulture) +" reais"); //concatenação
        
        
        }
    }
}
