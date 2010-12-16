using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem32
{
    class Problem32
    {
        static void Main(string[] args)
        {
            double test = 987654321;
            List<int> results = new List<int>();
            for (int multiplicand = 1; multiplicand < 200; multiplicand++)
            {

                for (int multiplier = 2000; multiplier > multiplicand; multiplier--)
                {
                    int product = multiplicand * multiplier;
                    if (product > test) break;

                    int[] counts = new int[10];
                    bool failed = false;
                    for (int i = 0; i < 10; i++)
                    {
                        foreach (char c in product.ToString().ToCharArray())
                        {
                            if (c - 48 == i) counts[i]++;
                        }
                        foreach (char c in multiplier.ToString().ToCharArray())
                        {
                            if (c - 48 == i) counts[i]++;
                        }
                        foreach (char c in multiplicand.ToString().ToCharArray())
                        {
                            if (c - 48 == i) counts[i]++;
                        }
                        if (i > 0 && counts[i] != 1) failed = true;
                        else if (counts[0] != 0)
                        {
                            failed = true;
                        }
                    }
                    if (!failed)
                    {
                        bool search = false;
                        foreach (int i in results)
                        {
                            if (product == i) search = true;
                        }
                        if (!search)
                        {
                            results.Add(product);
                            Console.WriteLine(multiplicand + " x " + multiplier + " = " + product);
                        }
                        
                    }
                }
            }
            int sum = 0;
            foreach (int i in results)
            {
                sum += i;
            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
    }
}
