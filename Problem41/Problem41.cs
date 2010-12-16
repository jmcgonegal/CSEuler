using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem41
{
    class Problem41
    {
        static List<int> GetPrimes(int val)
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
        static void Main(string[] args)
        {
            List<int> primes = GetPrimes(987654321);
            int max_digital = 0;
            foreach (int prime in primes)
            {
                char[] numbers = ("" + prime).ToCharArray();
                int[] count = new int[10];
                bool digital = true;
                foreach (char number in numbers)
                {
                    int value = number - 48;
                    count[value]++;
                    if (value > 0 && count[value] > 1) digital = false;
                    if (value == 0) digital = false;
                }
                for (int i = 1; i <= numbers.Length; i++)
                {
                    // 23 is invalid because #1 is missing
                    if (count[i] != 1) digital = false;
                }
                if (digital && prime > max_digital) max_digital = prime;
            }
            Console.WriteLine("Answer = " + max_digital);
            Console.ReadKey();
        }
    }
}
