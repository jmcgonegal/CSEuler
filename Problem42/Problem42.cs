using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem42
{
    class Word : IEquatable<Word>
    {
        private string word;
        private int value;
        public int getValue() {
            return value;
        }
        public Word(string w)
        {
            word = w;
            foreach (char c in w.ToCharArray())
            {
                value += c - 64; // 'A' = 65
            }
        }
        public Word(int v)
        {
            value = v;
        }
        public static int Sort(Word a, Word b)
        {
            return a.value.CompareTo(b.value);
        }
        public bool Equals(Word other)
        {
            return this.value == other.value;
        }
    }
    class Problem42
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("words.txt");
            StreamReader sr = new StreamReader(file.FullName);
            string input = sr.ReadToEnd();
            List<Word> list = new List<Word>();
            /* I'm assuming input is always uppercase */
            foreach (Match c in Regex.Matches(input, "\"([A-Z]+)\","))
            {
                string word = c.Groups[1].Value;
                list.Add(new Word(word));
 
            }
            list.Sort(Word.Sort);
            // max value of word is list
            Word w = list.Last();
            int count = 0;
            for (int n = 1; n <= w.getValue(); n++)
            {
                double tn = 0.5 * n * (n + 1);
                int val = (int)Math.Floor(tn);
                if (val == tn)
                {
                    if (list.Contains(new Word(val)))
                    {
                        foreach (Word word in list)
                        {
                            if (word.getValue() == val)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Answer = " + count);
            Console.ReadKey();
        }
    }
}
