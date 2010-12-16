using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problem75
{
    class Problem75
    {
        /// <summary>
        /// problem 75
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long answer = 0;
            List<int> numbers = new List<int>();
            List<int> unique = new List<int>();
            checked
            {
                for (int a = 1; a < 46341; a++)
                {
                    double a2 = a * a;
                    //double bsq = Math.Sqrt(a2 + a2);

                    for (int b = a; b < 46341; b++)
                    {

                        double b2 = b * b;
                        double c = Math.Sqrt(a2 + b2);
                        double c2 = c * c;
                        if (a + b + c > 1500000 || b > c) break;

                        if (Math.Floor(c) == c && (a2 + b2) / c2 == 1 && b < c && a + b + (int)Math.Floor(c) <= 1500000)
                        {
                            int triangle = a + b + (int)Math.Floor(c);
                            if (!unique.Contains(triangle))
                            {
                                unique.Add(triangle);
                                //Console.WriteLine(triangle + " = " + a + " " + b + " " + c);
                            }
                            else
                            {
                                numbers.Add(triangle);
                            }
                        }
                    }

                }
            }

            foreach (int triangle in unique)
            {
                if (!numbers.Contains(triangle))
                {
                    // it only shows up once
                    answer++;
                }
            }
            Console.WriteLine("Total " + unique.Count);

                /*Parallel.For<long>(1, 1500000, () => 0, (number, loop, always1) =>

            {
                if(number % 50 ==0)Console.WriteLine(number);
                long count = 0;
                
                for (double a = 1; a < number; a++)
                {
                    double bsq = Math.Sqrt((a * a) + ((number - a + 1) * (number - a + 1)));
                    for (double b = a; b < bsq; b++)
                    {
                        checked
                        {
                            double c = Math.Sqrt((a * a) + (b * b));
                            if (number == 120)
                            {
                                if ((a == 30 && b == 40))
                                {

                                }
                            }

                            if (number == a + b + c && b < c)
                            {
                                count++;
                                if (count > 1) break;
                                //Console.WriteLine("number = " + number + " a " + a + " b " + b + " c " + c);
                            }
                            if (number < a + b + c || b > c)
                            {
                                break;
                            }
                        }
                    }
                   if (count > 1) break;
                }
                if (count == 1)
                {
                    answer++;
                    //Console.WriteLine(subtotal + " " + number);
                    return 1;
                }
                return 0;
            },
                (x) => Interlocked.Add(ref answer, x)
            );*/

            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
