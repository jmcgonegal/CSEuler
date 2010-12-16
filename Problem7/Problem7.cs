using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Problem7
    {
        /// <summary>
        /// What is the 10001st prime number?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Answer = " + GetPrimeNumber(10001));
            Console.ReadKey();
        }
        static int GetPrimeNumber(int position)
        {
            List<int> primes = new List<int>();
            primes.Add(2); // lets seed 2
            int n = 3; // start at 3
            while (primes.Count < position)
            {
                bool prime = true;
                foreach (int j in primes)
                {
                    if (n % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primes.Add(n);

                }
                n += 2;
            }
            return primes.Last();
        }
    }
}
