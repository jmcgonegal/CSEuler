using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem35
{
    class Problem35
    {
        /// <summary>
        /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
        /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
        /// How many circular primes are there below one million?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> primes = Euler.Util.GetPrimes(999999);
            List<int> not_circlular = new List<int>(primes);
            List<int> count = new List<int>();
            foreach (int prime in primes)
            {

                if (("" + primes).Length == 1)
                {
                    count.Add(prime);
                }
                else
                {
                    char[] number = prime.ToString().ToCharArray();
                    bool circlular = true;


                    for (int i = 0; i < (number.Length * (number.Length - 1)) - 1; i++)
                    {
                        swap(number, i % (number.Length - 1), number.Length - 1);
                        
                        int value = int.Parse(new string(number));

                        if (!primes.Contains(value))
                        {
                            circlular = false;
                        }
                        else
                        {
                            //Console.WriteLine(prime + " = " + value);
                        }

                    }

                    
                    if (circlular)
                    {
                        count.Add(prime);
                        Console.WriteLine(prime + " is circlular ");
                    }
                    else
                    {
                        //Console.WriteLine(prime + " is not circlular ");
                    }
                }
            }
            Console.WriteLine("Primes = " + primes.Count + " Not Circular = " + not_circlular.Count + " Circular = " + count.Count);
            Console.WriteLine("Answer = " + (primes.Count - not_circlular.Count));
            /*
            char[] test = "123".ToCharArray();

            for (int i = 0; i < test.Length*(test.Length-1); i++)
            {
                swap(test, i % (test.Length-1), test.Length - 1);
                    Console.WriteLine(test);
            }*/
            Console.ReadKey();
        }
        static void swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
