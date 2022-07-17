using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
     public class DayOfWeek
    {
        public static void dayOfWeek()
        {
            Console.WriteLine("Enter the month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = ((d + x + 31*m0/12) % 7);
            switch(d0)
                {
                case 0:
                        Console.WriteLine("Day is Sunday");
                    break;
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                default:
                    Console.WriteLine("Day is Saturday");
                    break;
            }
        }
    }
}
