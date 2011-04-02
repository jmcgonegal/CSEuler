using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem99
{
    class Problem99
    {
        /*
         * 2^2 = 4
         * 4^8 = 65536
         * 2^16 = 65536 = 2^2*8
         */
        struct LineExp
        {
            public LineExp(int l, double exp)
            {
                power = exp;
                line = l;
            }
            public double power;
            public int line;
            public static int Compare(LineExp a, LineExp b)
            {
                return a.power.CompareTo(b.power);
            }
        }
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("base_exp.txt");
            List<LineExp> values = new List<LineExp>();
            int lineCount = 0;
            using (StreamReader sr = new StreamReader(file.FullName)) 
            {
                while (sr.Peek() >= 0) 
                {
                    lineCount++;
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    int value = int.Parse(""+split[0]);
                    int power = int.Parse(split[1]);

                    double mult_pow = Math.Log(value) * power;

                    // store 10^mult_pow with line number
                    values.Add(new LineExp(lineCount, mult_pow));

                }
            }
            // sort list
            values.Sort(LineExp.Compare);

            /*
            foreach (LineExp val in values)
            {
                Console.WriteLine(val.line + " " + val.power);
            }
            //*/
            Console.WriteLine("Answer = " + values[values.Count - 1].line);
            Console.ReadKey();
        }
    }
}
