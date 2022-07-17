using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumber
    {
       
            public static void Coupon()
            {
                Console.WriteLine("How many Coupons want to get print");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= count; i++)
                {
                    var chars = "QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm0123456789";
                    var code = new char[6];
                    var random = new Random();
                    for (int j = 0; j < code.Length; j++)
                    {
                        code[j] = chars[random.Next(chars.Length)];
                    }
                    var coupon = new String(code);
                    Console.WriteLine("Coupon {0} is {1}", i, coupon);
                }
            }
        }
    }
