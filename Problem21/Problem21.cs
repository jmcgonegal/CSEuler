using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem21
{
    class Problem21
    {
        List<int> getFactors(int number)
        {
            List<int> factors = new List<int>();

            factors.Add(1);
            //factors.Add(number);
            for (int j = 2; j <= (int)Math.Floor(number / 2.0); j++)
            {
                if (number % j == 0)
                {
                    factors.Add(j);
                }
            }
            return factors;
        }
        int getSumFactor(int number)
        {
            int sum = 0;

            foreach (int num in getFactors(number))
            {
                sum += num;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Problem21 prog = new Problem21();
            int[] sums = new int[10000];
            int number_total = 0;

            // calculate the sums of each number
            for (int i = 2; i < 10000; i++)
            {
                sums[i] = prog.getSumFactor(i);
            }
            List<int> numbers = new List<int>();

            // find pairs
            for (int i = 2; i < 10000 - 1; i++)
            {
                for (int j = i + 1; j < 10000; j++)
                {
                    if (sums[i] == j && sums[j] == i && i != j)
                    {
                        if (!numbers.Contains(i)) numbers.Add(i);
                        if (!numbers.Contains(j)) numbers.Add(j);

                    }
                }
            }

            // calculate sum of pairs
            foreach (int i in numbers)
            {
                number_total += i;
                //Console.WriteLine(i);
            }

            Console.WriteLine("Answer = " + number_total);
            Console.ReadKey();
        }
    }
}
