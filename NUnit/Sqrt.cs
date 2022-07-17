using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class Sqrt
    {
        public static void sqrt()
        {
            Console.WriteLine( "Enter the number to compute sqrt");
            int c = Convert.ToInt32(Console.ReadLine());
            double epsilon = 1E-15;
            double t = c;
            while(Math.Abs(t-c/t) > epsilon*t)
                t=(c/t+t)/2;
            Console.WriteLine(t);
        }
    }
}
