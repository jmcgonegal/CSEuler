using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem43
{
    class Problem43
    {
        static List<long> createPandigital10()
        {
            List<long> numbers = new List<long>();
            List<long> digits = new List<long>();
            for (int i = 1; i < 10; i++)
            {
                digits.Add(i);
            }
            digits.Add(0);
            checked
            {
                numbers = getNumbers(digits);
            }
            return numbers;
        }
        static List<long> getNumbers(List<long> digits)
        {
            List<long> numbers = new List<long>();
            foreach(int digit in digits)
            {
                List<long> temp = new List<long>(digits);
                if (temp.Count == 1)
                {
                    numbers.Add(digit);
                }
                else if (temp.Count > 1)
                {
                    temp.Remove(digit);
                    List<long> result = getNumbers(temp);
                    foreach (long r in result)
                    {
                        numbers.Add(r * 10 + digit);

                    }
                }
            }
            return numbers;
        }
        static bool isPandigital10(long num)
        {
            string digits = ("" + num);
            // only 10 digit numbers are valid
            if (digits.Length != 10) return false;
            bool notFound = false;
            for (int i = 0; i <= 9; i++)
            {
                if (!digits.Contains("" + i))
                {
                    notFound = true;
                }
            }
            // return true if 0 to 9 are all found
            return !notFound;
        }
        static void Main(string[] args)
        {
            List<long> numbers = createPandigital10();
            List<int> primes = Euler.Util.GetPrimes(18);
            long sum = 0;
            foreach (long number in numbers)
            {
                string digitstr = ""+number;
                if (digitstr.Length == 10)
                {
                    int[] digits = new int[11];
                    for (int i = 1; i <= 10; i++)
                    {
                        digits[i] = int.Parse("" + digitstr[i - 1]);
                    }
                    bool failed = false;
                    for (int n = 0; n < primes.Count; n++)
                    {
                        bool test = (0 == (digits[n + 2] * 100 + digits[n + 3] * 10 + digits[n + 4]) % primes[n]);
                        if (!test) failed = true;
                    }
                    checked
                    {
                        if (!failed) sum += number;
                    }
                }
            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
    }
}
