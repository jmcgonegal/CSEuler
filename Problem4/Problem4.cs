using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    class Problem4
    {
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        static void Main(string[] args)
        {
            int biggest = 0;
            for (int num1 = 999; num1 >= 100; num1--)
            {
                for (int num2 = num1; num2 >= 100; num2--)
                {
                    int test = num1 * num2;
                    string s = "" + test;
                    string t = ReverseString(s);
                    if (s == t)
                    {
                        if (biggest < test)
                        {
                            biggest = test;
                        }
                    }
                }
            }
            Console.WriteLine("Biggest = " + biggest);
            Console.ReadKey();
        }
        /// <summary>
        /// reverses a string
        /// </summary>
        /// <param name="s">string to reverse</param>
        /// <returns>reversed string</returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
