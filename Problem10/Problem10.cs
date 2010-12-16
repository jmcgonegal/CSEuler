using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Problem10
    {
        /// <summary>
        /// Find the sum of all the primes below two million.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long sum = 0;
            foreach (int i in GetPrimes(2000000))
            {
                sum += i;
            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
        static List<int> GetPrimes(int val)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            for(int n = 3; n<val;n+=2)
            {
                bool prime = true;
                foreach (int j in primes)
                {
                    if (n % j == 0)
                    {
                        prime = false;
                        
                        break;
                    }
                    if (j > Math.Sqrt(n) )
                    {
                        break;
                    }
                }
                if (prime)
                {
                    //Console.WriteLine(n);
                    primes.Add(n);
                }
            }
            
            return primes;
        }
    }
}
