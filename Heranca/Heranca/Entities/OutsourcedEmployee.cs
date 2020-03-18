using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) 
            : base (name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * AdditionalCharge;
        }
    }
}
