using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Problem1
    {
        /// <summary>
        /// Add all the natural numbers below one thousand that are multiples of 3 or 5.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 3; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    numbers.Add(i);
                }
                else if (i % 5 == 0)
                {
                    numbers.Add(i);
                }
            }
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine("Problem 1 Answer: " + sum);
            Console.ReadKey();
        }
    }
}
