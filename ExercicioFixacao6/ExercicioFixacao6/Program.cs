using System;
using System.Globalization;

namespace ExercicioFixacao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o nome do Titular: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldoConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, nomeTitular, saldoConta);
            }
            else
            {
                conta = new Conta(numeroConta, nomeTitular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.Write(conta.MostrarDadosDaConta());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            conta.RecebeDepositoBancario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta.MostrarDadosDaConta());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            conta.RealizaSaqueBancario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta.MostrarDadosDaConta());
        }
    }
}
