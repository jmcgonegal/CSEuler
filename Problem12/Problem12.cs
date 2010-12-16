using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem12
{
    class Problem12
    {
        
        static List<long> GetPrimes(long val)
        {
            List<long> primes = new List<long>();
            primes.Add(2);
            for(long n = 3; n<val;n+=2)
            {
                bool prime = true;
                foreach (long j in primes)
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
        static void Main(string[] args)
        {
            long answer = 0;
            bool done = false;
            long triangle_count = 1;
            long number = 1;
            long max = 0;
            while (!done)
            {
                triangle_count++;
                checked
                {
                        number += triangle_count;
                }
                List<long> factors = new List<long>();
                
                factors.Add(1);
                factors.Add(number);
                for (long j = 2; j <= (long)Math.Floor(number / 2.0); j++)
                {
                    if (number % j == 0)
                    {
                        factors.Add(j);
                    }
                }
                if (factors.Count > max)
                {
                    max = factors.Count;
                    Console.WriteLine(max + " num " + number + " pos " + triangle_count);
                }
                if (factors.Count > 500)
                {
                    answer = number;
                    done = true;
                }
            }
            // 576 num 76576500 pos 12375
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
