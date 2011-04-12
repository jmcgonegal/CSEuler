using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem57
{
    class Problem57
    {
        static void Main(string[] args)
        {
            int answer = 0;
            BigInteger top = 1;
            BigInteger bottom = 2;
            for (int expansion = 0; expansion < 1000; expansion++)
            {
                BigInteger numerator = top + bottom; // add 1
                if (numerator.ToString().Length > bottom.ToString().Length)
                {
                    answer++;
                }
                // seed the next values if we run the loop again
                BigInteger temp = (bottom * 2) + top;
                top = bottom;
                bottom = temp;
                
            }
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
