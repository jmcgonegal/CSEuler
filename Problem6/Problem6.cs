using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem6
{
    class Problem6
    {
        /// <summary>
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int calc = 100;
            int sum_sq = 0;
            for (int i = 1; i <= calc; i++)
            {
                sum_sq += i * i;
            }
            int sum = 0;
            for (int i = 1; i <= calc; i++)
            {
                sum += i;
            }
            int sq_sum = sum*sum;
            int answer = sq_sum - sum_sq;
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
