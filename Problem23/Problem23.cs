using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem23
{
    class Problem23
    {
        int getSumOfFactors(int number)
        {
            int sum = 1;

            for (int j = 2; j <= (int)Math.Floor(number / 2.0); j++)
            {
                if (number % j == 0)
                {
                    sum += j;
                }
            }
            return sum;
        }
        bool isPerfectNumber(int number)
        {
            return (number == getSumOfFactors(number));
        }
        bool isAbundantNumber(int number)
        {
            return (number < getSumOfFactors(number));
        }
        static void Main(string[] args)
        {
            Problem23 prog = new Problem23();
            BitArray abundantNumbers = new BitArray(28124);
            BitArray test = new BitArray(28124);
            //Console.WriteLine(prog.isPerfectNumber(28));
            //Console.WriteLine(prog.isPerfectNumber(12));
            int sumtotal = 0;

            for (int i = 2; i <= 28123; i++)
            {
                if (prog.isAbundantNumber(i))
                {
                    abundantNumbers[i] = true;
                }
            }
            for (int i = 2; i <= 28123; i++)
            {
                if (abundantNumbers[i])
                {
                    for (int j = 2; j <= 28123; j++)
                    {
                        if (i + j > 28123)
                        {
                            break;
                        }
                        if (abundantNumbers[j])
                        {
                            int sum = i + j;
                            test[sum] = true;
                        }
                    }
                }
            }
            // copy paste got me
            for (int i = 1; i <= 28123; i++)
            {
                if (!test[i])
                {
                    sumtotal += i;
                }
            }
            Console.WriteLine("Answer = " + sumtotal);
            Console.ReadKey();
        }
    }
}
