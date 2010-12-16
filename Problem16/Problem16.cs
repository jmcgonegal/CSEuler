using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem16
{
    class Problem16
    {
        int MAX = 500;// I'm lazy
        int[] bignum = null;
        Problem16(int num = 0)
        {
            bignum = new int[MAX];
            this.add(num);
        }
        void add(int value, int index = 0)
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
            for (int number = 0; number < MAX; number++)
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
        static void Main(string[] args)
        {
            Problem16 prog = new Problem16(1);
            for (int i = 0; i < 1000; i++)
            {
                prog.multiply(2);
            }
            Console.WriteLine("Answer = " + prog.sum());
            Console.ReadKey();
        }
    }
}
