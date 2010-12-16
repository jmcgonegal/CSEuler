using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = { new int[] {75},
                                new int[] {95,64},
                                new int[] {17,47,82},
                                new int[] {18,35,87,10},
                                new int[] {20,04,82,47,65},
                                new int[] {19,01,23,75,03,34},
                                new int[] {88,02,77,73,07,63,67},
                                new int[] {99,65,04,28,06,16,70,92},
                                new int[] {41,41,26,56,83,40,80,70,33},
                                new int[] {41,48,72,33,47,32,37,16,94,29},
                                new int[] {53,71,44,65,25,43,91,52,97,51,14},
                                new int[] {70,11,33,28,77,73,17,78,39,68,17,57},
                                new int[] {91,71,52,38,17,14,91,43,58,50,27,29,48},
                                new int[] {63,66,04,68,89,53,67,30,73,16,69,87,40,31},
                                new int[] {04,62,98,27,23,09,70,98,73,93,38,53,60,04,23}
                              };//*/
            /*int[][] numbers = { new int[] {3},
                                new int[] {7,4},
                                new int[] {2,4,6},
                                new int[] {8,5,9,3},
                              };//*/
            /*int[][] test = new int[][] {
                new int[1],
                new int[2],
                new int[3],
                new int[4],
                new int[5],
                new int[6],
                new int[7],
                new int[8],
                new int[9],
                new int[10],
                new int[11],
                new int[12],
                new int[13],
                new int[14]
            };*/
            //numbers.CopyTo(test,0);
            for (int row = numbers.Length - 2; row >= 0; row--)
            {
                for (int col = 0; col < numbers[row].Length; col++)
                {
                    int left = numbers[row + 1][col];
                    int right = numbers[row + 1][col + 1];
                    if (left > right)
                    {
                        numbers[row][col] += left;
                    }
                    else if (right > left)
                    {
                        numbers[row][col] += right;
                    }
                    //Console.Write(numbers[row][col] + " ");
                }
                //Console.WriteLine();
            }
            Console.WriteLine("Answer = " + numbers[0][0]);
            /*int pos = 0;
            //int sum = numbers[0][0];
            //Console.WriteLine(numbers[0][0]);
            int max_sum = numbers[0][0];
            string r = ""+numbers[0][0];
            for(int row = 0; row < numbers.Length - 1;row++)
            {
                if (numbers[row + 1][pos+1] > numbers[row + 1][pos] && pos + 1 <= numbers[row + 1].Length-1)
                {
                    //Console.WriteLine(numbers[row + 1][pos+1] + " > " + numbers[row + 1][pos]);
                    pos += 1;
                }
                else
                {
                    //Console.WriteLine(numbers[row + 1][pos] + " < " + numbers[row + 1][pos + 1]);
                    // opps
                }
                max_sum += numbers[row + 1][pos];
                r += " + " + numbers[row + 1][pos];
                
            }
            Console.WriteLine(r + " = " + max_sum);
            for (int bottom = 0; bottom < numbers.Length - 1; bottom++)
            {
                string result = "";
                int position = bottom;
                int sum = 0;
                for (int row = numbers.Length - 1; row >= 0; row--)
                {
                    sum += numbers[row][position];
                    
                    //Console.WriteLine(numbers[row][position]);
                    if (row > 0)
                    {
                        result += numbers[row][position] + " + ";
                        if (position > 0 && position < numbers[row].Length - 1 && row > 1)
                        {
                            int left =numbers[row - 1][position-1];
                            int right = numbers[row - 1][position];
                            if ( left < right)
                            {
                                // left number > right number
                                //Console.WriteLine(right + " > " + left);
                                //position--;
                                //
                            }
                            else if (numbers[row - 1][position - 1] == numbers[row - 1][position] && position - 1 != 0)
                            {
                                // error
                                throw new Exception();
                            }
                            else
                            {
                                // we can only pick position-1 because numbers[row].size - 1 = numbers[row-1].size 
                                //Console.WriteLine(left + " > " + right);
                                position--;
                            }
                            
                        }
                        else if (position == numbers[row].Length - 1)
                        {
                            position--;
                        }
                        else
                        {
                            // we only have 1 position to take
                            position = 0;
                        }
                        
                    }
                    else
                    {
                        // done
                        result += numbers[row][position] + " = " + sum;
                    }

                    //Console.WriteLine(numbers[row + 1][position]);
                }
                if (sum > max_sum)
                {
                    Console.WriteLine(result);
                    max_sum = sum;
                }
                
            }*/

            //Console.WriteLine("Answer = " + max_sum);
            Console.ReadKey();
        }
    }

}
