using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class Problem5
    {
        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int MAX = 20;
            List<int> factors = new List<int>();
            int number = 1;
            for (int i = 2; i <= MAX; i++)
            {
                bool prime = true;
                foreach (int j in factors)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    factors.Add(i);
                    number *= i;
                    //Console.WriteLine("" + i);
                }

            }
            int adjust = 1;
            for (int i = 2; i <= MAX; i++)
            {
                int remainder = number % i;
                if (remainder != 0)
                {
                    //Console.WriteLine(i + " R: " + remainder);
                    bool test = false;
                    foreach (int factor in factors)
                    {
                        if (i / remainder == factor) test = true;
                    }
                    if (test) adjust *= i / remainder;
                }

            }

            // answer is 232792560
            int answer = number * adjust;

            // some error checking
            for (int i = 2; i <= MAX; i++)
            {
                int remainder = answer % i;
                if (remainder != 0)
                {
                    Console.WriteLine("error " + i + " R " + remainder);
                }

            }
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
