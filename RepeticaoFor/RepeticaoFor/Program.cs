using System;

namespace RepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiros você vai digitar?");
            int contador = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for(int i=0; i < contador; i++)
            {
                Console.WriteLine("Digite o valor #"+ (i+1));
                soma += int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("A soma dos valores é: " + soma);
        }
    }
}
