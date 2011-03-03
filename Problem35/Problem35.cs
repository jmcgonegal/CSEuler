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
            //List<int> circlular = new List<int>(primes);
            List<int> count = new List<int>();
            foreach (int prime in primes)
            {
                
                if (!count.Contains(prime))
                {
                    if (prime < 10)
                    {
                        count.Add(prime);
                    }
                    else
                    {
                        // get circular values
                        List<int> values = getRotations(prime);//getCirclular(prime);

                        bool test = true;

                        // test if they are prime
                        foreach (int value in values)
                        {
                            if (!primes.Contains(value))
                            {
                                test = false;
                                break;
                            }
                        }
                        // if all the numbers are prime, add those to the circlular primes
                        if (test)
                        {
                            foreach (int value in values)
                            {
                                if (!count.Contains(value))
                                {
                                    count.Add(value);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Answer = " + count.Count);

            Console.ReadKey();
        }
        static void rotate(char[] array)
        {
            char temp = array[0];
            for(int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }
            array[array.Length-1] = temp;
        }
        static List<int> getRotations(int num)
        {
            char[] number = num.ToString().ToCharArray();
            List<int> circlular = new List<int>();
            for (int n = 0; n < number.Length; n++)
            {
                rotate(number);

                int value = int.Parse(new string(number));
                if (!circlular.Contains(value) /*&& number[0] != '0' */) circlular.Add(value);
            }
            circlular.Sort();
            return circlular;
        }
        static void swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[(i + j) % array.Length];
            array[(i + j) % array.Length] = temp;
        }
        static List<int> getCirclular(int num)
        {
            char[] number = num.ToString().ToCharArray();
            List<int> circlular = new List<int>();
            for(int n = 0; n < number.Length; n++)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    swap(number, n, i);

                    int value = int.Parse(new string(number));
                    if(!circlular.Contains(value) && number[0] != '0') circlular.Add(value);
                }
            }
            circlular.Sort();
            return circlular;
        }
    }
}
