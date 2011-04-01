using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem39
{
    class Problem39
    {
        static int countPerimeterSolutions(int p)
        {
            int count = 0;
            for (double a = 3; a < p /2; a++)
            {
                for (double b = a; b < p /2; b++)
                {
                    double c = Math.Sqrt( (a*a) + (b*b));
                    if (a + b + c == p)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int max = 0, max_p = 0;
            for (int p = 5; p <= 1000; p++)
            {
                int solutions = countPerimeterSolutions(p);
                if (solutions > max)
                {
                    max = solutions;
                    max_p = p;
                }
            }
            Console.WriteLine("Answer = " + max_p);
            Console.ReadKey();
        }
    }
}
