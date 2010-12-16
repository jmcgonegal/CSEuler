using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem20
{
    class Problem20
    {
        int MAX = 500;// I'm lazy
        int[] bignum = null;
        Problem20()
        {
            bignum = new int[MAX];
        }
        void add(int value, int index=0)
        {
            int test = value + bignum[index];
            if (test >= 10)
            {
                
                add((int)Math.Floor(test / 10.0), index + 1);
            }
            bignum[index] = test % 10;
        }

        void multiply(int value)
        {
            for(int number = 0; number < MAX; number++)
            {
                bignum[number] *= value;
            }
            for (int number = 0; number < MAX; number++)
            {
                if (bignum[number] >= 10) this.add(0, number);
            }
        }
        public int sum()
        {
            int sum = 0;
            for (int number = 0; number < MAX; number++)
            {
                sum += bignum[number];
            }
            return sum;
        }
        /// <summary>
        /// Find the sum of digits in 100!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Problem20 prog = new Problem20();
            prog.add(1);

            for (int i = 1; i <= 100; i++)
            {
                prog.multiply(i);
            }
            Console.WriteLine("Answer = " + prog.sum());
            Console.ReadKey();
        }
    }
}
