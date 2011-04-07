using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem50
{
    class Problem50
    {
        static void Main(string[] args)
        {
            List<int> primes = Euler.Util.GetPrimes(1000000);
            int[] counts = new int[primes.Count];
            int max_count = 0;
            int max_sum = 0;
            // lets cheat a little by checking the largest 1000 primes
            for (int k = primes.Count - 1; k >= primes.Count - 1000; k--)
            {
                int check_prime = primes[k];
                for (int i = 0; i < primes.Count; i++)
                {
                    int sum = 0;
                    int counter = 0;
                    if (primes.Count - i > max_count)
                    {
                        for (int j = i; j < primes.Count; j++)
                        {
                            if (sum < check_prime)
                            {
                                counter++;
                                sum += primes[j];
                                if (counter > max_count)
                                {
                                    if (sum == check_prime)
                                    {
                                        max_sum = sum;
                                        max_count = counter;
                                    }
                                }
                            }
                            else
                            {
                                break; // sum is bigger/equal to the checked prime
                            }
                        }
                    }
                    else
                    {
                        break; // we cant get a bigger count
                    }
                }
            }

            Console.WriteLine("Answer = " + max_sum);
            Console.ReadKey();
        }
    }
}
