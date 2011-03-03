using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem36
{
    class Problem36
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static bool isPalindromic(int number)
        {
            string value = "" + number;
            string rvalue = Euler.Util.ReverseString(value);
            string bin = Convert.ToString(number, 2);
            string rbin = Euler.Util.ReverseString(bin);
            int test1 = value.CompareTo(rvalue);
            int test2 = bin.CompareTo(rbin);
            return (test1 == 0 && test2 == 0);
        }
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (isPalindromic(i))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Answer = " + sum);
        }
    }
}
