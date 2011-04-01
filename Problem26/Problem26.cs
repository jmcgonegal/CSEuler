using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem26
{
    class Problem26
    {
        static int MAX_LENGTH = 2000;
        static int findCyclicNumberDigits(List<int> digits)
        {
            if (digits.Count < MAX_LENGTH) return 0;
            string value = "";
            for (int i = 0; i < digits.Count; i++)
            {
                value += digits[i];
            }

            for (int i = 0; i < digits.Count /2; i++)
            {
                string repeat = "";
                for (int period = 0; period < digits.Count - i; period++)
                {
                    
                    repeat += digits[i + period];
                    string temp = value.Substring(0,i);
                    while (temp.Length < value.Length)
                    {
                        temp += repeat;
                    }
                    temp = temp.Substring(0, value.Length);

                    if (temp == value && repeat.Length < MAX_LENGTH/2)
                    {
                        if (repeat.Length > 900)
                        {
                            string test = value.Substring(0, i);
                        }
                        return repeat.Length;
                    }
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int max_repeat = 0;
            int answer = 0;
            // even divisors are never repeating
            for (int divisor = 3; divisor < 1000; divisor+=2)
            {
                List<int> digits = new List<int>();
                int dividend = 10;
                int remainder = 0;
                while (digits.Count < MAX_LENGTH && dividend != 0)
                {

                    Math.DivRem(dividend, divisor, out remainder);
                    int digit = (dividend - remainder) / divisor;
                    digits.Add(digit);
                    dividend = 10 * remainder;
                }
                
                // we have a repeating number
                if (digits.Count == MAX_LENGTH)
                {
                    int number = findCyclicNumberDigits(digits);

                    if (number > max_repeat)
                    {
                        max_repeat = number;
                        answer = divisor;
                        Console.WriteLine("1/" + divisor + " = " + number + " repeating digits");
                    }
                }
                
            }
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
