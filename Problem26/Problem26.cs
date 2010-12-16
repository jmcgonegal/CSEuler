using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem26
{
    class Problem26
    {
        static int find(int demoninator)
        {
            int MAX = 5000;
            int[] bignum = new int[MAX];
            bignum[0] = 10;

            for (int i = 0; i < MAX - 1; i++)
            {
                //if (bignum[i] == 0) break;
                int remainder = 0;
                Math.DivRem(bignum[i], demoninator, out remainder);
                int test = (bignum[i] - remainder) / demoninator;
                bignum[i] = test;
                int number = bignum[i];
                bignum[i + 1] = remainder * 10;

            }
            bignum[MAX - 1] /= 10;
            int count = 0;
            for (int i = 1; i < MAX / 2; i++)
            {
                if (bignum[0] == bignum[i])
                {
                    int match = 1;
                    for (int j = 1; j < i; j++)
                    {
                        if (bignum[j] == bignum[i + j])
                        {
                            match++;
                        }
                        else break;
                    }
                    if (match > 1 && count == 0) count = match;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int answer = 0;
            int max = 0;
            for (int number = 1; number <= 1000; number++)
            {
                int match = find(number);
                if (match > max && match != 499)
                {
                    max = match;
                    answer = number;
                    //Console.WriteLine(number + " = " + match);
                }
                else 
                {

                }
            }

            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
