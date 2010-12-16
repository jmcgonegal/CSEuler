using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem237
{
    class Problem237
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            LinkedList<int> result = GetPrimeNumbers(150);
            result.AddFirst(1); // lets seed 1 for this project only
            int[] primes = result.ToArray();
           /* for (int i = 0; i < primes.Length; i++)
            {
                int b = primes.ToArray()[i];
                for (int j = 0; j <= i; j++)
                {
                    int a = primes.ToArray()[j];
                    if (a <= b)
                    {
                        int product = (a * a) + (b * b);
                        //sum += a;
                        //if(product == 65)
                        //Console.WriteLine(a + " " + b + " = " + product);
                    }
                    else
                    {
                        // wtf
                    }
                }
            }*/
            for (int number = 1; number < 150 * 150; number++)
            {
                List<int> factors = new List<int>();
                int sqsum = 0;
                for (int i = 0; i < primes.Length; i++)
                {
                    int b = primes[i];
                    for (int j = 0; j <= i; j++)
                    {
                        int a = primes[j];
                        int product = (a * a) + (b * b);

                        if (a <= b && number == product)
                        {
                            
                            sqsum += a;
                            //Console.WriteLine(a + " " + b + " = " + product);
                        }
                    }
                }
                if(sqsum>0)Console.WriteLine(sqsum + " = " + number);
                sum += sqsum;
            }
    /*
                var result = from a in primes
                             from b in primes
                             where a <= b && (a * a) + (b * b) == number
                             select a;
                foreach (int i in result)
                {
                    if(i == 65)
                    Console.WriteLine(i.ToString());
                }*/
                
           // }
            /*
            foreach (int a in primes)
            {
                //KeyValuePair<int, int> c;
                foreach (int b in primes)
                {
                    if (a <= b)
                    {
                        int a2 = a * a;
                        int b2 = b * b;
                        if (Math.Sqrt(a2 + b2))
                        {
                            sum += a;
                            Console.WriteLine(a + " " + b);
                        }
                    }
                }
            }
        }
            
        int sum = 0;
        Dictionary<int,int> factors = new Dictionary<int, int>();

            
        foreach (int prime in primes)
        {
            //Console.WriteLine(prime + " ");
        }*/
            Console.WriteLine("Answer = " + sum);
            Console.ReadKey();
        }
        static LinkedList<int> GetPrimeNumbers(int value)
        {

            LinkedList<int> primes = new LinkedList<int>();
            primes.AddLast(2); // lets seed 2
            int n = 3; // start at 3
            while (n < value)
            {
                bool prime = true;
                foreach (int j in primes)
                {
                    if (n % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primes.AddLast(n);

                }
                n += 2;
            }
            return primes;
        }
    }
}
