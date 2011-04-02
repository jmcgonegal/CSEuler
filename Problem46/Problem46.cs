using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem46
{
    class Problem46
    {
        static void Main(string[] args)
        {
            List<int> primes = Euler.Util.GetPrimes(100000);

            int composite = 9;
            bool failed = false;
            while (!failed)
            {
                int square = 0;
                bool foundPrime = false;
                while (2 * square * square < composite && !foundPrime)
                {
                    int value = composite - (2 * square * square);

                    if (primes.Contains(value))
                    {
                        foundPrime = true;
                    }

                    square++;
                }

                if (!foundPrime)
                {
                    failed = true;
                }
                else
                {
                    composite += 2; // keep it odd
                }
            }
            Console.WriteLine("Answer = " + composite);
            Console.ReadKey();
        }
    }
}
