using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Problem9
    {
        static int PythagoreanTripletProduct(int value)
        {
            for (int a = 1; a < value; a++)
            {
                for (int b = a; b < value; b++)
                {
                    for (int c = b; c < value; c++)
                    {
                        if (a + b + c == value && (a * a) + (b * b) == c * c)
                        {
                            return a * b * c;
                        }
                    }
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int answer = PythagoreanTripletProduct(1000);
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
