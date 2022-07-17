using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 0; i < n; i++)
            {
                sum=num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(sum);
            }
            
        }
    }
}
