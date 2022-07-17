using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class DecimalToBinary
    {
        public static void Binary()
        {
            int num, i;
            Console.WriteLine("Enter a Number to convert it into Binary");
            num = Convert.ToInt32(Console.ReadLine());
            int[] binary = new int[num];
            for (i = 0; num > 0; i++)
            {
                binary[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("Binary of input number is ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(binary[i]);
            }
        }
    }
}
    

