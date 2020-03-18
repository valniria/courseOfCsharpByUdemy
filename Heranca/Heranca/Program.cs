﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                               
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name
                    + " - $ "
                    + emp.payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
