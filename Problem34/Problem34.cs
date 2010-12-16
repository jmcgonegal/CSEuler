using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem34
{
    class Problem34
    {
        static void Main(string[] args)
        {
            // seed array        0! 1! 2! 3! 4!  5!   6!   7!    8!     9!
            int[] factorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int max = 0;
            foreach (int number in factorials)
            {
                max += number;
            }

            int answer = 0;
            for (int i = 3; i < max; i++)
            {
                int sum = 0;
                foreach (char val in ("" + i).ToCharArray())
                {
                    int number = val - 48;
                    sum += factorials[number];
                    if (sum == i)
                    {
                        Console.WriteLine(i);
                        answer += i;
                    }
                }

            }
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
