using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem30
{
    class Problem30
    {
        int sumOfDigits(int number, int power)
        {
            int sum = 0;
            foreach (char c in number.ToString())
            {
                int num = c - 48;
                sum += (int) Math.Pow(num,power);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Problem30 prog = new Problem30();

            int sum = 0;
            for (int i = 2; i < 999999; i++)
            {
                if(i == prog.sumOfDigits(i, 5))
                {
                    sum+= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
         }
        
    }
}
