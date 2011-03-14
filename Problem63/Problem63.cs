using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem63
{
    class Problem63
    {
        public static decimal pow(int bse, int exp)
        {
            decimal value = 1;
            for (int i = 0; i < exp; i++)
            {
                value *= bse;
            }
            return value;
        }
        static void Main(string[] args)
        {
            int count = 0;
            // 9^22 = 21 digits, max(n) = 21
            for (int n = 1; n <= 21; n++) 
            {
                // a cannot be greater than 9, 10^2 = 100 or 3 digits
                for (int a = 1; a <= 9; a++)
                {
                    decimal b = Problem63.pow(a, n);

                    if (("" + b).ToCharArray().Length == n)
                    {
                        count++;
                        Console.WriteLine(a + "^" + n + " = " + b);
                    }
                }
            }
            
            Console.WriteLine("Answer = " + count);
            Console.ReadKey();
        }
    }
}
