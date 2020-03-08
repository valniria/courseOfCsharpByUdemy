using System;
using System.Globalization;

namespace ExercicioFixacao5
{
    class ConversorDeMoeda
    {
        static double Iof = 0.06;
        public static double CalcularValorASerPago(double dolar, double quantidade)
        {
            double aux = dolar * quantidade;
            return aux * Iof + aux;
        }

    }
}
