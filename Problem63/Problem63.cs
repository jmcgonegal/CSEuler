using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem63
{
    class Problem63
    {
        static void Main(string[] args)
        {
            int count = 0;
            // we overflow at 9^20
            for (int n = 1; n <= 19; n++) 
            {
                // a cannot be greater than 9, 10^2 = 100 or 3 digits
                for (long a = 1; a < 10; a++)
                {
                    long b = (long)Math.Pow(a, n);
                    if (("" + b).ToCharArray().Length == n)
                    {
                        count++;
                        Console.WriteLine(a + "^" + n + " = " + b);
                    }
                }
            }
            
            // by hand
            // 9^20 and 9^21 = valid, 9^22 = 21 digits
            Console.WriteLine("9^20 = 12157665459056928801");
            Console.WriteLine("9^21 = 109418989131512359209");
            count += 2;

            Console.WriteLine("Answer = " + count);
            Console.ReadKey();
        }
    }
}
