using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem67
{
    class Problem67
    {
        static int[][] readTriangles()
        {
            FileInfo file = new FileInfo("triangle.txt");
            List<int[]> list = new List<int[]>();
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<int> temp = new List<int>();
                    foreach (string number in line.Split(' '))
                    {
                        temp.Add(int.Parse(number));
                    }
                    list.Add(temp.ToArray());
                }
            }
            return list.ToArray();
        }
        static void Main(string[] args)
        {
            int[][] numbers = readTriangles();

            for (int row = numbers.Length - 2; row >= 0; row--)
            {
                for (int col = 0; col < numbers[row].Length; col++)
                {
                    int left = numbers[row + 1][col];
                    int right = numbers[row + 1][col + 1];
                    if (left >= right)
                    {
                        numbers[row][col] += left;
                    }
                    else if (right > left)
                    {
                        numbers[row][col] += right;
                    }

                }
                // error checking
                //if (row + 1 != numbers[row].Length) Console.WriteLine(row + " = " + numbers[row].Length);
            }

            Console.WriteLine("Answer = " + numbers[0][0]);
            Console.ReadKey();
        }
    }
}
