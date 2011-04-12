using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem58
{
    class Problem58
    {
        static void Main(string[] args)
        {
            const int MAX = int.MaxValue / 3;

            BitArray pbits = Euler.Util.GetPrimeArray(MAX);
            int current = 1;
            int row = 2;
            double total = 1;
            double diagonalPrime = 0;
            bool under10 = false;
            int side = 3;
            while (!under10)
            {
                int max = (int) Math.Pow(row + 1, 2) + current;
                for (int i = 0; i < 4; i++)
                {
                    current += (row - 1) * 2;
                    if (current > MAX) throw new Exception();
                    total++;
                    if (pbits[current])
                    {
                        diagonalPrime++;
                    }
                }

                double check = diagonalPrime / total;
                if (check < 0.1)
                {
                    under10 = true;
                }
                else
                {
                    row++;
                    side += 2;
                }
            }
            Console.WriteLine("Answer = " + side);
            Console.ReadKey();
        }
    }
}
