using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double valuePerHours { get; set; }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            this.valuePerHours = valuePerHours;
        }

        public virtual double payment()
        {
            return Hours * valuePerHours;
        }

    }
}
