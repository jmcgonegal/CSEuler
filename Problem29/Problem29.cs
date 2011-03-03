using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem29
{
    class Problem29
    {
        static void Main(string[] args)
        {
            List<double> distinct = new List<double>();
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    double term = Math.Pow(a, b);
                    if (!distinct.Contains(term))
                    {
                        distinct.Add(term);
                    }
                }
            }
            Console.WriteLine("Answer = " + distinct.Count);
            Console.ReadKey();
        }
    }
}
