using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem15
{
    class Problem15
    {
        static void Main(string[] args)
        {
            int GRIDSIZE = 20;
            long[,] counts = new long[GRIDSIZE+1,GRIDSIZE+1];

            for (int x = GRIDSIZE; x >= 0; x--)
            {
                for (int y = GRIDSIZE; y >= 0; y--)
                {
                    if (y == GRIDSIZE)
                    {
                        counts[x, y] = 1;
                    }
                    else if (x == GRIDSIZE)
                    {
                        counts[x, y] = 1;
                    }
                    else
                    {
                        counts[x, y] = counts[x + 1, y] + counts[x, y + 1];
                    }
                }
            }

            Console.WriteLine("Answer = " + counts[0, 0]);
            Console.ReadKey();
        }
    }
}
