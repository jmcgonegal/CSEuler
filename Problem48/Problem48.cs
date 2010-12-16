using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem48
{
    class Problem48
    {
        public int[] bignum = null;
        private int MAX = 5000;
        public int max_index = 0;
        Problem48(int val = 0)
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
            if (index >= max_index) max_index = index + 1;
        }
        void add(int[] bigadd)
        {
            for (int i = 0; i < bigadd.Length; i++)
            {
                this.add(bigadd[i],i);
            }

        }
        void addpow(int num, int exp)
        {
            Problem48 temp = new Problem48(1);
            for (int i = 0; i < exp; i++ )
            {
                temp.mult(num);

            }
            this.add(temp.bignum);
        }
        void mult(int value)
        {
            for (int i = 0; i < bignum.Length; i++)
            {
                bignum[i] *= value;
            }
            for (int i = 0; i < bignum.Length; i++)
            {
                this.add(0, i);
            }
        }
        static void Main(string[] args)
        {
            Problem48 prog = new Problem48();
            for (int i = 1; i <= 1000; i++)
            {
                prog.addpow(i, i);
            }
            
            Console.Write("Answer = ");

            for (int i = prog.max_index - 4991; i >= 0; i--)
            {
                Console.Write(prog.bignum[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
