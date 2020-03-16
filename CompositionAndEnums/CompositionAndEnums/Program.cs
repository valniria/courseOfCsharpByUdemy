using System;
using System.Globalization;
using CompositionAndEnums.Entities.Enums;
using CompositionAndEnums.Entities;

namespace CompositionAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            DateTime date;
            double valuePerHour;
            int duration;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #"+(i+1)+" contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.addContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            double income = worker.income(year, month);
            Console.WriteLine("Income for " + monthAndYear + ": " + income.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
