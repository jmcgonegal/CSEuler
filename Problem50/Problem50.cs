using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem50
{
    class Problem50
    {
        static void Main(string[] args)
        {
            const int MAX = 1000000;
            List<int> primes = Euler.Util.GetPrimes(MAX);
            BitArray numbers = new BitArray(MAX);
            int max_count = 0;
            int max_sum = 0;

            // I could speed this up because the GetPrimes function basically makes this already
            foreach (int prime in primes)
            {
                numbers[prime] = true;
            }

            // rewrite, not having to do list lookups makes this fast
            for (int i = 0; i < primes.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < primes.Count; j++)
                {
                    sum += primes[j];
                    if (sum > MAX) break;
                    if (j - i > max_count)
                    {
                        // is prime
                        if (numbers[sum])
                        {
                            max_sum = sum;
                            max_count = j - i;
                        }
                    }
                }
            }


            Console.WriteLine("Answer = " + max_sum);
            Console.ReadKey();
        }
    }
}
