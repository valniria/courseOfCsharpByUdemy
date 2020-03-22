using System;
using System.Globalization;

namespace Interfaces.Entities
{
    class Invoice
    {
        public double BasicPayments { get; set; }
        public double Tax { get; set; }


        public Invoice()
        {

        }
        public Invoice(double basicPayments, double tax)
        {
            BasicPayments = basicPayments;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayments + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payments "
                + BasicPayments.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
