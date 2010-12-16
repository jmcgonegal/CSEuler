using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Euler
{
    public class Util
    {
        public static List<int> GetPrimes(int val)
        {
            BitArray bits = new BitArray(val, true);

            for (int n = 2; n < (int)Math.Sqrt(val) + 1; n++)
                if (bits.Get(n))
                    // eliminate multiples of n
                    for (int nmult = n * 2; nmult < val; nmult += n)
                        bits.Set(nmult, false);


            List<int> primes = new List<int>();

            for (int i = 2; i < val; i++)
                if (bits.Get(i))
                    primes.Add(i);

            return primes;
        }
    }
    

}
