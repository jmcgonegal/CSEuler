using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem47
{
    class Problem47
    {
        static List<int> primes = Euler.Util.GetPrimes(1000000);
        static int twoConsecutiveStart()
        {
            int last = getPrimeFactors(1).Count;
            for (int i = 2; i < 100; i++)
            {
                int count = getPrimeFactors(i).Count;
                if (count == 2 && last == 2)
                {
                    // last number is the start
                    return i-1;
                }
                last = count;
            }
            return 0;
        }
        static int threeConsecutiveStart()
        {
            int[] last = new int[2];
            last[0] = getPrimeFactors(1).Count;
            last[1] = getPrimeFactors(2).Count;

            for (int i = 3; i < primes[primes.Count - 1]; i++)
            {
                
                int count = getPrimeFactors(i).Count;

                if (last[0] == 3 && last[1] == 3 && count == 3)
                {
                    // last number is the start
                    return i - 2;
                }
                last[0] = last[1];
                last[1] = count;
            }
            return 0;
        }
        static int fourConsecutiveStart()
        {
            int[] last = new int[3];
            last[0] = getPrimeFactors(1).Count;
            last[1] = getPrimeFactors(2).Count;
            last[2] = getPrimeFactors(3).Count;

            for (int i = 4; i < primes[primes.Count-1]; i++)
            {
                int count = getPrimeFactors(i).Count;
                if ( last[0] == 4 && last[1] == 4 && last[2] == 4 && count == 4)
                {
                    // last number is the start
                    return i - 3;
                }
                last[0] = last[1];
                last[1] = last[2];
                last[2] = count;
            }
            return 0;
        }
        static List<int> getPrimeFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 0; i < primes.Count; i++)
            {
                if (primes[i] > number) break;
                if (number % primes[i] == 0)
                {
                    factors.Add(primes[i]);
                }

            }
            return factors;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Two = " + twoConsecutiveStart());
            Console.WriteLine("Three = " + threeConsecutiveStart());
            Console.WriteLine("Answer = " + fourConsecutiveStart());
            Console.ReadKey();
        }
    }
}
