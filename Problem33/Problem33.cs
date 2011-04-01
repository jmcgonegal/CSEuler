using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem33
{
    class Problem33
    {
        static void Main(string[] args)
        {
            int answer_n = 1, answer_d = 1;
            for (int d = 11; d <= 99; d++)
            {
                for (int n = 10; n < d; n++)
                {
                    if (n % 10 != 0) // 10/20  is too simple
                    {
                        double answer = 1.0 * n / d;
                        string nu = "" + n;
                        string de = "" + d;
                        int top = 0, bottom = 0;
                        if (nu[0] == de[0])
                        {
                            top = int.Parse("" + nu[1]);
                            bottom = int.Parse("" + de[1]);
                        }
                        else if (nu[1] == de[1])
                        {
                            top = int.Parse("" + nu[0]);
                            bottom = int.Parse("" + de[0]);
                        }
                        else if (nu[1] == de[0])
                        {
                            top = int.Parse("" + nu[0]);
                            bottom = int.Parse("" + de[1]);
                        }
                        else if (nu[0] == de[1])
                        {
                            top = int.Parse("" + nu[1]);
                            bottom = int.Parse("" + de[0]);
                        }
                        if (bottom != 0 && top != 0)
                        {
                            double test = 1.0 * top / bottom;
                            if (test == answer)
                            {
                                answer_n *= top;
                                answer_d *= bottom;
                                Console.WriteLine(n + "/" + d + " = " + top + "/" + bottom);
                            }
                        }
                    }
                }
                
            }
            // 8/800 = 1/100, lazy
            Console.WriteLine(answer_n + "/" + answer_d + " Answer = " + answer_d / answer_n);
            Console.ReadKey();
        }
    }
}
