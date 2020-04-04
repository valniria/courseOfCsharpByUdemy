using System;
using DelegateMulticast.Services;

namespace DelegateMulticast
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        delegate void VoidBinaryOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation operation = CalculationService.Sum;

            double result = operation(a, b);

            Console.WriteLine(result);

            VoidBinaryOperation voidOperation = CalculationService.ShowMax;
            voidOperation += CalculationService.ShowSum;

            voidOperation(a, b);

            Console.WriteLine(voidOperation);

        }
    }
}
