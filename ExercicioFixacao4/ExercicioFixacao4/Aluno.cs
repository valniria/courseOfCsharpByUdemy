using System;
using System.Globalization;

namespace ExercicioFixacao4
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public bool VerificaAprovacao(double nota)
        {
            return nota >= 60.0;
        }

        public double QuantoFaltaParaSerAprovado(double nota)
        {
            return (nota - 60.0) * -1;
        }

    }
}
