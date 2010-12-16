using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Problem3
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        static void Main(string[] args)
        {
            List<long> factors = new List<long>();
            long number = 600851475143;
            long i = 3;
            long test = 1;
            while (i < number)
            {
                if (test == number) break;
                i += 2;

                if (number % i == 0)
                {
                    bool prime = true;
                    foreach (int j in factors)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                        }
                    }
                    if (prime)
                    {
                        test *= i;
                        factors.Add(i);
                        Console.WriteLine(i + " ");
                    }
                }
            }
            Console.WriteLine("Answer = " + factors.Last());
            Console.ReadKey();
        }
    }
}
