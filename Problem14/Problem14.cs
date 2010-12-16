using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem14
{
    class Problem14
    {
        /// <summary>
        /// Which starting number, under one million, produces the longest chain?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long max_count = 0;
            long max_number = 0;
            for (long number = 1; number < 1000000; number++)
            {
                checked
                {
                    long n = number;
                    long count = 1;
                    while (n > 1)
                    {
                        count++;
                        if (n % 2 == 1)
                        {
                            // n is odd
                            n = 3 * n + 1;
                        }
                        else
                        {
                            // n is even
                            n = n / 2;
                        }
                    }
                    if (count > max_count)
                    {
                        max_count = count;
                        max_number = number;
                    }
                }
            }
            Console.WriteLine("Count = " + max_count);
            Console.WriteLine("Answer = " + max_number);
            Console.ReadKey();
        }
    }
}
