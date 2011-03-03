using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
 * If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations 
 * of 0, 1 and 2 are:
 * 
 * 012   021   102   120   201   210
 * 
 * What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
 */
namespace Problem24
{
    class Problem24
    {
        static void Main(string[] args)
        {
            /* well this is damn ugly */
            List<string> numbers = new List<string>();
            // 1
            for (int a = 0; a <= 9; a++)
            {
                // 2
                for (int b = 0; b <= 9; b++)
                {
                    if (a != b)
                    {
                        // 3
                        for (int c = 0; c <= 9; c++)
                        {
                            if (c != b && c != a)
                            {
                                for (int d = 0; d <= 9; d++)
                                {
                                    // 4
                                    if (d != c && d != b && d != a)
                                    {
                                        // 5
                                        for (int e = 0; e <= 9; e++)
                                        {
                                            if (e != d && e != c && e != b && e != a)
                                            {
                                                // 6
                                                for (int f = 0; f <= 9; f++)
                                                {
                                                    if (f != e && f != d && f != c && f != b && f != a)
                                                    {
                                                        // 7
                                                        for (int g = 0; g <= 9; g++)
                                                        {
                                                            if (g != f && g != e && g != d && g != c && g != b && g != a)
                                                            {
                                                                // 8
                                                                for (int h = 0; h <= 9; h++)
                                                                {
                                                                    if (h != g && h != f && h != e && h != d && h != c && h != b && h != a)
                                                                    {
                                                                        // 9
                                                                        for (int i = 0; i <= 9; i++)
                                                                        {
                                                                            if (i != h && i != g && i != f && i != e && i != d && i != c && i != b && i != a)
                                                                            {
                                                                                // 0
                                                                                for (int j = 0; j <= 9; j++)
                                                                                {
                                                                                    if (j != i && j != h && j != g && j != f && j != e && j != d && j != c && j != b && j != a)
                                                                                    {
                                                                                        string number = "" + a + b + c + d + e + f + g + h + i + j;
                                                                                        numbers.Add(number);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            numbers.Sort();
            Console.WriteLine("Answer = " + numbers[999999]);
            Console.ReadKey();
        }
    }
}
