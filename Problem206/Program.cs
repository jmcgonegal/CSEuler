using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem206
{
    class Program
    {
        public static bool isMatch(BigInteger number)
        {
            bool isNumber = ((number % 10) == 0);
            int i;

            for (i = 1; i < 10 && isNumber; i++)
            {
                number /= 100;
                isNumber = ((number % 10) == (10 - i));
            }
            return isNumber;
        }

        static void Main(string[] args)
        {
            long min = 1020304050607080900;
            long max = 1929394959697989990;

            long sq_min = (long)Math.Floor(Math.Sqrt(min));
            long sq_max = (long)Math.Ceiling(Math.Sqrt(max));

            Parallel.For(sq_min, sq_max, delegate(long i)
            //for(long i = sq_min; i <= sq_max; i++)
            {

                BigInteger temp = i;
                BigInteger value = temp * temp;
                
                // lazy
                //char[] test = value.ToString().ToCharArray();
                //if (test.Length == 19 && test[0] == '1' && test[2] == '2' && test[4] == '3' && test[6] == '4' && test[8] == '5' && test[10] == '6' && test[12] == '7' && test[14] == '8' && test[16] == '9')
                if(isMatch(value))
                {
                    Console.WriteLine("Answer = " + temp + " is " + value);
                }
            }
            );
            Console.ReadKey();
        }
    }
}
