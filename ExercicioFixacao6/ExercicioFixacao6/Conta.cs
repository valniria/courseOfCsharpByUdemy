using System;
using System.Globalization;

namespace ExercicioFixacao6
{
    class Conta
    {

        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; set; }
        public double SaldoDaConta { get; private set; }

        public double Imposto = 5.00;
        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
        }

        public Conta(int numeroDaConta, string titularDaConta, double saldo) : this (numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldo;
        }

        public string MostrarDadosDaConta()
        {
            return "Conta: "
                + NumeroDaConta
                + ", Titular: "
                + TitularDaConta
                + ", Saldo: $ "
                + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void RecebeDepositoBancario(double valor)
        {
            SaldoDaConta += valor;
        }

        public void RealizaSaqueBancario(double valor)
        {
            SaldoDaConta = SaldoDaConta - valor - Imposto;
        }

    }
}
