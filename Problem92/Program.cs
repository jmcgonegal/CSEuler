using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem92
{
    class Program
    {
        static int getSquareSum(int value)
        {
            int result = 0;
            string digits = value.ToString();
            foreach (char c in digits)
            {
                int val = int.Parse("" + c);
                result += val*val;
            }
            
            return result;

        }
        static void Main(string[] args)
        {
            const int MAX = 10000000;
            int count_89 = 0;

            // BitArrays are fast
            BitArray arrive_at_89 = new BitArray(MAX);
            BitArray arrive_at_1 = new BitArray(MAX);
            arrive_at_1[1] = true;
            arrive_at_89[89] = true;
            for (int i = 1; i < MAX; i++)
            {
                bool repeat = false;

                List<int> squares = new List<int>();
                int test = i;
               
                while (!repeat)
                {
                    squares.Add(test);
                    if (arrive_at_1[test])
                    {
                        foreach (int sq in squares)
                        {
                            arrive_at_1[sq] = true;
                        }
                        repeat = true;
                    } 
                    else if (arrive_at_89[test])
                    {
                        count_89++;
                        foreach (int sq in squares)
                        {
                            arrive_at_89[sq] = true;
                        }
                        repeat = true;
                    }

                    test = getSquareSum(test);
                }


            }
            Console.WriteLine("Answer = " + count_89);
            Console.ReadKey();
        }
    }
}
