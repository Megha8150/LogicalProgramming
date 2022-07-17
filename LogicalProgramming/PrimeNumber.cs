using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNumber
    {
        public static void PrimeNumbers()
        {


            Console.WriteLine ("Enter the Number to check prime or not:");
            int n = Convert.ToInt32 (Console.ReadLine());
            int flag = 0;

            if (n == 0 || n == 1)
            {
                Console.WriteLine (n + " is not prime number");
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine (n + " is not prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(n + " is prime number");
                }
            }
        }
    }
}
