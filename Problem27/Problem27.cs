using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27
{
    class Problem27
    {
        int MAX = 2500000;
        List<int> primes;
        public Problem27()
        {
            primes = Euler.Util.GetPrimes(MAX);
        }
        
        public bool isPrime(int val)
        {
            if (val > MAX) throw new Exception("too big");
            return primes.Contains(val);
        }
        static void Main(string[] args)
        {
            Problem27 prog = new Problem27();
            int max_n = 0; 

            // saw after brute forcing that all b's are primes, speeds up stuff a lot
            List<int> under1000 = Euler.Util.GetPrimes(1000); 
            
            foreach (int b in under1000)
            {
                Parallel.For(-999, 999, a =>
                {
                    int nplus = max_n + 1;
                    // test to make sure the equation has at least 1 more than the maximum N found
                    if (prog.isPrime((nplus * nplus) + (a * nplus) + b))
                    {
                        int n = 0;
                        while (prog.isPrime((n * n) + (a * n) + b))
                        {
                            n++;
                        }
                        if (n - 1 >= max_n)
                        {
                            max_n = n - 1; // lock max_n
                            Console.WriteLine("a: " + a + " b: " + b + " n=" + (n - 1) + " product is " + (a * b));
                        }
                    }
                });
            }
            
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
