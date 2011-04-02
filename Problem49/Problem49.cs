using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem49
{
    class Problem49
    {
        
        static void Main(string[] args)
        {
            List<int> primes = Euler.Util.GetPrimes(10000);

            foreach (int prime in primes)
            {
                if (prime > 1000)
                {
                    List<int> digits = new List<int>();
                    foreach (char digit in ("" + prime).ToCharArray())
                    {
                        digits.Add(int.Parse("" + digit));
                    }

                    List<int> permutations = Euler.Util.getPermutations(digits);
                    permutations.Sort();

                    foreach (int perm in permutations)
                    {
                        int third = prime + (2 * (perm - prime));
                        if (perm > prime && primes.Contains(perm) && permutations.Contains(third) && primes.Contains(third))
                        {
                            Console.WriteLine(prime + "" + perm + "" + third);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
