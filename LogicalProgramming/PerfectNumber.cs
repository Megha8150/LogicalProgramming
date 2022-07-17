using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
     class PerfectNumber
    {
        public static void perfectNumbers()
        {
            int value = 0;
            Console.WriteLine("Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    value += i;
                }
            }
            if (value == num)
            {
                Console.WriteLine(num+ " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num+ " ia not a Perfect Number");
            }
        }
    }
}
