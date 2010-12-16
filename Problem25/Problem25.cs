using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem25
{
    class Problem25
    {
        int MAX = 1000;// I'm lazy
        public int[] bignum = null;
        Problem25(int val = 0)
        {
            bignum = new int[MAX];
            this.add(val);
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
        void add(int[] bigadd)
        {
            for (int i = 0; i < bigadd.Length; i++)
            {
                this.add(bigadd[i],i);
            }
        }
        bool testDigit(int d)
        {
            // return true if the digit is set to something other than 0
            return bignum[d - 1] != 0;
        }
        static void Main(string[] args)
        {
            Problem25 fib = new Problem25(1);
            Problem25 last = new Problem25(1);
            int count = 2;
            while (!fib.testDigit(1000))
            {
                Problem25 temp = new Problem25();
                temp.add(fib.bignum);
                fib.add(last.bignum);
                last = temp;
                count++;
            }
            Console.WriteLine("Answer = " + count);
            Console.ReadKey();
        }
    }
}
