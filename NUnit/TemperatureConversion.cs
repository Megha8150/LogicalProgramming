using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class TemperatureConversion
    {
        public static void temperatureConversion()
        {
            Console.WriteLine("Choose an option for Temperature Conversion");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
                {
                case 0:
                    Console.WriteLine("Enter Temperature in Celsius");
                    double celsius1 = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit1 = ((celsius1) * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit " + fahrenheit1);
                    break;
                case 1:
                    Console.WriteLine("Enter Temperature in Fahrenheit");
                    double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
                    double celsius2 =(fahrenheit2 - 32) * 5 / 9;
                    Console.WriteLine("Temperature in celcius " +celsius2);
                    break;
                default:
                    Console.WriteLine("Enter Correct Input");
                    break;
            }
            }
    }
}
