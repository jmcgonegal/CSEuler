using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem52
{
    class Problem52
    {
        bool doublesHaveSameDigits(int x)
        {
            int x2 = 2 * x;
            int x3 = 3 * x;
            int x4 = 4 * x;
            int x5 = 5 * x;
            int x6 = 6 * x;

            List<char> s = x.ToString().ToCharArray().ToList();
            List<char> s2 = x2.ToString().ToCharArray().ToList();
            List<char> s3 = x3.ToString().ToCharArray().ToList();
            List<char> s4 = x4.ToString().ToCharArray().ToList();
            List<char> s5 = x5.ToString().ToCharArray().ToList();
            List<char> s6 = x6.ToString().ToCharArray().ToList();

            s.Sort();
            s2.Sort();
            s3.Sort();
            s4.Sort();
            s5.Sort();
            s6.Sort();

            bool equal = true;
            for (int i = 0; i < s.Count; i++)
            {
                if (!(s[i] == s2[i] && s[i] == s3[i] && s[i] == s4[i] && s[i] == s5[i] && s[i] == s6[i]))
                {
                    // fail
                    equal = false;
                    break;
                }
            }

            return equal;
        }
        static void Main(string[] args)
        {
            Problem52 prog = new Problem52();
            int number = 0;
            bool found = false;
            while (!found)
            {
                number++;
                found = prog.doublesHaveSameDigits(number);
            }
            Console.WriteLine("Answer = " + number);
            Console.ReadKey();
        }
    }
}
