using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem44
{
    class Problem44
    {
        static List<long> getPentagonalList(long count, long offset = 0)
        {
            List<long> numbers = new List<long>();
            for (long n = 1 + offset; n <= count + offset; n++)
            {
                numbers.Add((n * ((3 * n) - 1)) / 2);
            }
            return numbers;
        }
        static int getPentagonal(int n)
        {
            return (n * ((3 * n) - 1)) / 2;
        }
        static void Main(string[] args)
        {
            int min_diff = 0;
            List<int> numbers = new List<int>();// = getPentagonalList(5000);
            int counter = 1;
            numbers.Add(getPentagonal(counter));
            while(min_diff == 0)
            {
                counter++;
                int current = getPentagonal(counter);
                foreach (int penta in numbers)
                {
                    int diff = Math.Abs(penta - current);
                    if ((diff < min_diff || min_diff == 0) && numbers.Contains(diff))
                    {
                        int sum = penta + current;
                        int increment = 1;
                        bool failed = false;
                        bool success = false;

                        // wow I don't like this part
                        while (!failed && !success)
                        {
                            // check ahead until the sum <= nextPentalgonal
                            int nextPentalgonal = getPentagonal(counter + increment);
                            if (sum == nextPentalgonal)
                            {
                                success = true;
                            }
                            else if (nextPentalgonal > sum)
                            {
                                failed = true;
                            }
                            increment++;
                        }

                        if (success)
                        {
                            min_diff = diff;
                            break;
                        }
                    }
                }
                numbers.Add(current);
            }
            Console.WriteLine("Answer = " + min_diff);
            Console.ReadKey();
        }
    }
}
