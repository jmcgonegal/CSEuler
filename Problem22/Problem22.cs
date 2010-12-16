using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Problem22
{
    class Problem22
    {
        /// <summary>
        /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into
        /// alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain 
        /// a name score.
        /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, 
        /// COLIN would obtain a score of 938 × 53 = 49714.
        /// What is the total of all the name scores in the file?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SortedList<string, int> names = new SortedList<string, int>();
            
            FileInfo file = new FileInfo("names.txt");
            StreamReader sr = new StreamReader(file.FullName);

            string input = sr.ReadToEnd();
            foreach (Match m in Regex.Matches(input, "\"(?<name>[^\"]*)\""))
            {
                
                string name = m.Groups["name"].Value.ToUpper();
                int sum = 0;
                foreach (char c in name)
                {
                    sum += c - 64;
                }

                names.Add(name, sum);

            }
            int answer = 0;

            checked
            {
                for (int position = 0; position < names.Count; position++)
                {
                    answer += names.ToArray()[position].Value * (position+1);
                }
            }
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
