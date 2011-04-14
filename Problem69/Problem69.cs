using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;

namespace Problem69
{
    class Problem69
    {
        static void Main(string[] args)
        {
            const int MAX = 1000000;

            // wrote this after brute forcing the answer and seeing its just prime factors
            List<int> primes = Euler.Util.GetPrimes(MAX);
            int total = 1;
            foreach (int prime in primes)
            {
                int next = total * prime;
                if (next > MAX)
                    break;
                else
                    total = next;
            }
            Console.WriteLine("Answer = " + total);
            Console.ReadKey();



            /*
            // seed initial values
            double max_phi = 2;
            int max_n = 2;
            ReaderWriterLockSlim cacheLock = new ReaderWriterLockSlim();
            // brute force! ~ 2 min to get answer
            Parallel.For(3, MAX, n =>
            {
                int prime_count = 1;
                BitArray coprime = new BitArray(n + 1, true);
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        for (int j = i; j < n; j += i)
                        {
                            coprime[j] = false;
                        }
                    }

                }
                for (int i = 2; i < n; i++)
                {
                    if (coprime[i])
                    {
                        prime_count++;
                    }
                }

                double phi = 1.0 * n / (double)prime_count;
                cacheLock.EnterUpgradeableReadLock();
                if (phi > max_phi)
                {
                    cacheLock.EnterWriteLock();
                    Console.WriteLine(n + " = " + phi);

                    max_phi = phi;
                    max_n = n;
                    cacheLock.ExitWriteLock();
                }
                cacheLock.ExitUpgradeableReadLock();
            }
            );
            Console.WriteLine("Answer = " + max_n);
            // */
            Console.ReadKey();
        }
    }
}
