using System;
using System.Globalization;

namespace exerciciosPropostosOO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaA, pessoaB;

            pessoaA = new Pessoa();
            pessoaB = new Pessoa();

            //*** CALCULAR MAIOR IDADE ***

            //Console.WriteLine("Digite os dados da primeira pessoa");
            //Console.Write("Nome: ");
            //pessoaA.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoaA.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite os dados da segunda pessoa");
            //Console.Write("Nome: ");
            //pessoaB.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoaB.Idade = int.Parse(Console.ReadLine());

            //if(pessoaA.Idade > pessoaB.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoaA.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoaB.Nome);
            //}

            //*** CALCULAR SALÁRIO MÉDIO ***

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.Write("Nome: ");
            pessoaA.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoaA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.Write("Nome: ");
            pessoaB.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoaB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário Médio: " + ((pessoaA.Salario + pessoaB.Salario)/2.0).ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
