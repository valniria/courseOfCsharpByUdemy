using System;
using System.Globalization;

namespace ExerciciosPropostosSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            //Apresentar a soma de dois números

            //Console.WriteLine("Digite o primeiro número:");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número:");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("A soma dos números é:");
            //Console.WriteLine(n1 + n2); ;


            //-------------------------------------------------------
            //EXERCÍCIO 2
            //Calcular a área de uma círculo

            //Console.WriteLine("Digite o valor do raio de um círculo:");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double pi = 3.14159;
            //double area = pi * Math.Pow(raio, 2);

            //Console.WriteLine("O valor da área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));


            //-------------------------------------------------------
            //EXERCÍCIO 3
            //Calcular a diferença do produto de A e B pelo produto de C e D

            //Console.WriteLine("Digite o número de A:");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de B:");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de C:");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de D:");
            //int d = int.Parse(Console.ReadLine());

            //Console.WriteLine("Diferença do produto de A e B para C e D é:");
            //Console.WriteLine(a * b - c * d);


            //-------------------------------------------------------
            //EXERCÍCIO 4
            //Dados de funcionário

            //Console.WriteLine("Digite o numero do funcionário:");
            //int numero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            //int horasTrabalhadas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor hora de trabalho do funcionário:");
            //double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = valorHora * horasTrabalhadas;

            //Console.WriteLine("NUMBER: " + numero);
            //Console.WriteLine("SALARY: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));


            //-------------------------------------------------------
            //EXERCÍCIO 5
            //Calcular valores a pagar

            //Console.WriteLine("Digite o numero de peças, valor unitário e o codigo da peça número 1:");
            //string[] peca1 = Console.ReadLine().Split(' ');

            //Console.WriteLine("Digite o numero de peças, valor unitário e o codigo da peça número 2:");
            //string[] peca2 = Console.ReadLine().Split(' ');

            //double valorPeca1 = double.Parse(peca1[1], CultureInfo.InvariantCulture) * double.Parse(peca1[2], CultureInfo.InvariantCulture);

            //double valorPeca2 = double.Parse(peca2[1], CultureInfo.InvariantCulture) * double.Parse(peca2[2], CultureInfo.InvariantCulture);

            //double valorAPagar = valorPeca1 + valorPeca2;

            //Console.WriteLine("Valor a pagar: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));


            //-------------------------------------------------------
            //EXERCÍCIO 6
            //Calcular dados geométricos

            Console.WriteLine("Digite os valores de A, B e C");
            string[] valores = Console.ReadLine().Split(' ');

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangulo = (a * c) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
