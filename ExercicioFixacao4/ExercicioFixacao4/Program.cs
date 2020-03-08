using System;
using System.Globalization;

namespace ExercicioFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal(aluno.Nota1, aluno.Nota2, aluno.Nota3);

            Console.WriteLine("Nota final: " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));

            bool resultado = aluno.VerificaAprovacao(notaFinal);


            if (resultado)
            {
                Console.WriteLine("Resultado: APROVADO");
            }
            else
            {
                Console.WriteLine("Resultado: REPROVADO");
                Console.WriteLine("Faltaram " + aluno.QuantoFaltaParaSerAprovado(notaFinal).ToString("F2", CultureInfo.InvariantCulture) + " pontos");

            }
        }
    }
}
