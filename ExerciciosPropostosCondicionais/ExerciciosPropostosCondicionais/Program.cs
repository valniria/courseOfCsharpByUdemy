using System;
using System.Globalization;

namespace ExerciciosPropostosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 1 
            //Identificar se o número é negativo ou positivo

            //Console.WriteLine("Digite um número inteiro: ");
            //int numero = int.Parse(Console.ReadLine());

            //if(numero >= 0)
            //{
            //    Console.WriteLine("POSITIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVO");
            //}


            // EXERCÍCIO 2 
            //Identificar se o número é Par ou Ímpar

            //Console.WriteLine("Digite um número inteiro: ");
            //int numero = int.Parse(Console.ReadLine());

            //if(numero%2 ==0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}


            // EXERCÍCIO 3 
            //Identificar se o número é Par ou Ímpar

            //Console.WriteLine("Digite um número inteiro para A: ");
            //string[] numerosAEB = Console.ReadLine().Split(' ');
            //int a = int.Parse(numerosAEB[0]);
            //int b = int.Parse(numerosAEB[1]);

            //if(a % b == 0 || b % a == 0)
            //{
            //    Console.WriteLine("São Multiplus!");
            //} 
            //else
            //{
            //    Console.WriteLine("Não São Multiplus!");
            //}


            // EXERCÍCIO 4 
            //Calcular a duração de um jogo através das horas iniciais e finais

            //Console.WriteLine("Digite a hora inicial e final de um jogo em números inteiros: ");
            //string[] horasDoJogo = Console.ReadLine().Split(' ');

            //int horaInicial = int.Parse(horasDoJogo[0]);
            //int horaFinal = int.Parse(horasDoJogo[1]);
            //int duracao;

            //if(horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}

            //Console.WriteLine("O jogo durou " + duracao + " horas(s)");


            // EXERCÍCIO 5
            //Calcular valor a pagar

            //Console.WriteLine("Digite o codigo e a quantidade do produto: ");
            //string[] produtoEQuantidade = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(produtoEQuantidade[0].);
            //int quantidade = int.Parse(produtoEQuantidade[1]);

            //double valor;

            //if(codigo == 1)
            //{
            //    valor = quantidade * 4.0;
            //} 
            //else if(codigo == 2)
            //{
            //    valor = quantidade * 4.5;
            //}
            //else if(codigo == 3)
            //{
            //    valor = quantidade * 5.0;
            //}
            //else if(codigo == 4)
            //{
            //    valor = quantidade * 2.0;
            //}
            //else
            //{
            //    valor = quantidade * 1.5;
            //}

            //Console.WriteLine("Total R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));


            // EXERCÍCIO 6
            //Identificar qual o intervalor que o numero recebido se encontra

            //Console.WriteLine("Digite um numero");
            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if(numero < 0.0 || numero > 100.0)
            //    Console.WriteLine("Numero fora do intervalo");
            //else if (numero <= 25)
            //    Console.WriteLine("Intervalo (0 a 25)");
            //else if(numero <= 50)
            //    Console.WriteLine("Intervalo (25 a 50)");
            //else if(numero <= 74)
            //    Console.WriteLine("Intervalo (50 a 74)");
            //else
            //    Console.WriteLine("Intervalo (75 a 100)");


            // EXERCÍCIO 7
            //Identificar qual o quadrante pertence o ponto

            //Console.WriteLine("Digite os numeros para x e y");
            //string[] coordenadas = Console.ReadLine().Split(' ');

            //double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            //if(x == 0 & y == 0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if(x == 0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if(y == 0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else if(x > 0.0 && y > 0.0)
            //    Console.WriteLine("Q1");
            //else if (x < 0.0 && y > 0.0)
            //    Console.WriteLine("Q2");
            //else if (x < 0.0 && y < 0.0)
            //    Console.WriteLine("Q3");
            //else
            //    Console.WriteLine("Q4");


            //EXERCICIO 8
            //Calcular o valor do imposto que a pessoa precisa pagar de acordo com o salário

            Console.WriteLine("Digite o valor do salário do cidadão");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.0)
            {
                imposto = 0.0;
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }
                
        }
    }
}
