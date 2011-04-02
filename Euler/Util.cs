using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Euler
{
    public class Util
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static List<int> getPermutations(List<int> digits)
        {
            List<int> numbers = new List<int>();
            foreach (int digit in digits)
            {
                List<int> temp = new List<int>(digits);
                if (temp.Count == 1)
                {
                    numbers.Add(digit);
                }
                else if (temp.Count > 1)
                {
                    temp.Remove(digit);
                    List<int> result = getPermutations(temp);
                    foreach (int r in result)
                    {
                        int value = r * 10 + digit;
                        if(!numbers.Contains(value)) numbers.Add(value);
                    }
                }
            }
            return numbers;
        }

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
        static void Main()
        {

        }
    }
    

}
