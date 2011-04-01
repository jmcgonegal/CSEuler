using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem55
{
    class Problem55
    {
        static bool isPalindromic(BigInteger num)
        {
            string rev = Euler.Util.ReverseString("" + num);
            BigInteger reverse = BigInteger.Parse("" + rev);
            if (num == reverse)
            {

            }
            return num == reverse;
        }
        static bool isLychrel(BigInteger num)
        {
            for (int i = 0; i <= 50; i++)
            {
                // run the addition first, can be palindromic and lychrel
                num += BigInteger.Parse(Euler.Util.ReverseString("" + num));
                if(isPalindromic(num))
                {
                    return false;
                }
                
            }
            return true;
        }
        static void Main(string[] args)
        {
            int lychrel = 0;
            for (int num = 0; num < 10000; num++)
            {
                if (isLychrel(num))
                {
                    Console.WriteLine(num);
                    lychrel++;
                }

            }
            Console.WriteLine("Answer = " + lychrel );
            Console.ReadKey();
        }
    }
}
