using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem15
{
    class Problem15
    {
        static int MoveGrid(int posx, int posy, int sizex, int sizey)
        {
            int result = 0;
            if (posy >= sizey && posx >= sizex)
            {
                // success, we found a route
                return 1;
            }
            if (posx < sizex)
            {
                // move right
                result = MoveGrid(posx + 1, posy, sizex, sizey);
            }
            if (posy < sizey)
            {
                // move down
                result +=  MoveGrid(posx, posy + 1, sizex, sizey);
            }
            return result;
        }
        static void Main(string[] args)
        {
            long answer = 0; //MoveGrid(0,0,20,20);
            long[,] counts = new long[20, 20];
            checked
            {
                for (int x = 0; x < 20; x++)
                {
                    for (int y = 0; y < 20; y++)
                    {
                        if (x != 0 && y != 0)
                        {
                            counts[x, y] = 2 + counts[x - 1, y] + counts[x, y - 1];
                        }
                        else if (x != 0 && y == 0)
                        {
                            counts[x, y] = 1 + counts[x - 1, y];
                        }
                        else if (x == 0 && y != 0)
                        {
                            counts[x, y] = 1 + counts[x, y - 1];
                        }
                        else if (x == 0 && y == 0)
                        {
                            counts[x, y] = 1;
                        }
                    }
                }
            }
            answer = counts[19, 19];
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
