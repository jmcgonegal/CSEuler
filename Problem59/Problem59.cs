using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem59
{
    class Problem59
    {
        static void Main(string[] args)
        {
            FileInfo cipherFile = new FileInfo("cipher1.txt");
            StreamReader sr = cipherFile.OpenText();

            string line = sr.ReadToEnd();
            sr.Close();
            string[] split = line.Split(',');
            int[] values = new int[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                values[i] = int.Parse(split[i]);
            }

            for (int a = 98; a <= 122; a++)
            {
                for (int b = 98; b <= 122; b++)
                {
                    for (int c = 98; c <= 122; c++)
                    {
                        int[] key = { a, b, c };

                        string result = "";
                        bool fail = false;
                        int sum = 0;
                        for (int i = 0; i < values.Length; i++)
                        {
                            int decode = values[i] ^ key[i % 3];
                            sum += decode;

                            // fail if greater than z and less than space
                            if (decode < 32 || decode > 122)
                            {
                                fail = true;
                                break;
                            }
                            result += (char)decode;
                        }
                        if (!fail && result.Contains("the"))
                        {
                            Console.WriteLine(result);
                            Console.WriteLine("Answer = " + sum);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
