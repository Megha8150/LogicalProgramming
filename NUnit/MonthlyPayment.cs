using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class MonthlyPayment
    {
        public static void monthlyPayment()
        {
            Console.WriteLine("Enter Priniciple Amount");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter term of loan in years");
            double noofyears = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Interest rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            double n = 12 * noofyears;
            double r = rate / (12 * 100);
            double payment = (principle * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Payment is " +payment);
        }
    }
}
