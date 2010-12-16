using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem28
{
    class Problem28
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for(int i = 3; i <= 1001; i+=2)
            {
                checked
                {
                    int distance = i - 1;
                    int top_right = i * i;
                    int top_left = top_right - distance;
                    int bottom_left = top_left - distance;
                    int bottom_right = bottom_left - distance;
                    sum += top_left + top_right + bottom_left + bottom_right;
                }

            }
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
    }
}
