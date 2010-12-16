using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem53
{
    class Problem53
    {
        static double factorial(double from, double until=1)
        {
            if (until < 1) until = 1;
            if (from == 0) { return 1; }
            else if (from == until) return from;
            else if (from < until)
            {
                return 1;
            }
            else
            {
                double answer = 1;
                while (from >= until)
                {
                    checked
                    {
                        answer *= from;
                    }
                    from--;
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            double count = 0;
            for (double n = 1; n <= 100; n++)
            {
                for (double r = 1; r <= n; r++)
                {
                    double result = factorial(n, r + 1) / factorial(n - r);
                    // count values greater than 1 million
                    if (result > 1000000) count++;
                }
            }

            Console.WriteLine("Answer = " +  count);
            Console.ReadKey();
        }
    }
}
