using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem37
{
    class Problem37
    {
        static void Main(string[] args)
        {
            List<int> primes = Euler.Util.GetPrimes(1000000);
            int count = 0;
            int sum = 0;
            foreach (int prime in primes)
            {
                if (prime > 10)
                {
                    int length = ("" + prime).Length;
                    bool fail = false;
                    for (int i = 0; i < length-1; i++)
                    {
                        // left to right
                        string sub = ("" + prime).Substring(i + 1);
                        if (sub[0] == '0')
                        {
                            // fail
                            fail = true;
                            break;
                        }
                        else
                        {
                            // left to right
                            int left = int.Parse(sub);
                            // right to left
                            int right = int.Parse(("" + prime).Substring(0, length - (i + 1)));
                            if (!primes.Contains(left))
                            {
                                fail = true;
                                break;
                            }
                            if (!primes.Contains(right))
                            {
                                fail = true;
                                break;
                            }
                        }
                    }
                    if (!fail)
                    {
                        count++;
                        sum += prime;
                        Console.WriteLine(prime);
                        if (count == 11)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
    }
}
