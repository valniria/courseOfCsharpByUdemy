using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            int id;
            string name;
            double salary;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
            }
            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
