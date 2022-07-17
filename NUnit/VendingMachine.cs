using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class VendingMachine
    {
        public static void Machine()
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int thou = amount / 1000;
            Console.WriteLine("Number of thousand notes : " + thou);
            amount = amount % 1000;
            int Fhund = amount / 500;
            Console.WriteLine("Number of five-hundred notes : " + Fhund);
            amount = amount % 500;
            int hund = amount / 100;
            Console.WriteLine("Number of hundred notes : " + hund);
            amount = amount % 100;
            int fifty = amount / 50;
            Console.WriteLine("Number of fifty notes : " + fifty);
            amount = amount % 50;
            int tens = amount / 10;
            Console.WriteLine("Number of tens notes : " + tens);
            amount = amount % 10;
            int five = amount / 5;
            Console.WriteLine("Number of five notes : " + five);
            amount = amount % 5;
            int twos = amount / 2;
            Console.WriteLine("Number of two notes : " + twos);
            amount = amount % 2;
            int ones = amount / 1;
            Console.WriteLine("Number of one notes : " + ones);
            amount = amount % 1;
        }
    }
}
    

