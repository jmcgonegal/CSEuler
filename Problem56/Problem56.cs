using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem56
{
    class Problem56
    {
        static void Main(string[] args)
        {
            int max_sum = 0;
            for (int a = 1; a < 100; a++)
            {
                for (int b = 1; b < 100; b++)
                {
                    BigInteger num = BigInteger.Pow(a,b);
                    int sum = 0;
                    foreach (char digit in num.ToString())
                    {
                        sum += int.Parse("" + digit);
                    }
                    if (max_sum < sum)
                    {
                        max_sum = sum;
                    }
                    
                }
            }
            Console.WriteLine("Answer = " + max_sum);
            Console.ReadKey();
        }
    }
}
