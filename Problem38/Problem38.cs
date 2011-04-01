using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem38
{
    class Problem38
    {
        static int pandigital(int number, List<int> n)
        {
            string value = "";
            foreach (int digit in n)
            {
                value += "" + (number * digit);
            }
            if (value.Length > 9) return -1;
            if (value.Length < 9) return 0;
            bool notFound = false;
            for (int i = 1; i <= 9; i++)
            {
                if (!value.Contains(""+i))
                {
                    notFound = true;
                }
            }
            if (!notFound)
            {
                return int.Parse(value);
            }
            else
            {
                // did not contain 1 through 9 in a 9digit number
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int max = 0;
            List<int> digits = new List<int>();
            digits.Add(1);
            for (int n = 2; n < 1000; n++)
            {
                digits.Add(n);
                for (int number = 1; number <= 99999; number++)
                {
                    int val = pandigital(number, digits);
                    if (val == -1)
                    {
                        // number is larger than 9 digits
                        break;
                    }

                    if (val.ToString().Length == 9 && val > max)
                    {
                        max = val;
                    }
                    
                }
            }
            Console.WriteLine("Answer = " + max);
            Console.ReadKey();
        }
    }
}
