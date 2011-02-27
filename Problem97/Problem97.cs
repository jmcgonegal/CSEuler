using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem97
{
    class Problem97
    {
        int[] digits = new int[10];
        public Problem97(int number)
        {
            for (int i = 0; i < number.ToString().Length; i++)
            {
                char a = number.ToString()[number.ToString().Length-i-1];
                digits[9 - i] = int.Parse(""+ a) ;
                
            }
        }
        public void simplify()
        {
            for (int i = 9; i > 0; i--)
            {
                if (digits[i] >= 10)
                {
                    digits[i - 1] += (digits[i] - (digits[i] % 10)) / 10;
                    digits[i] %= 10;
                }
            }
            digits[0] %= 10;
        }
        public void multiply(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                digits[i] *= number;
            }
            this.simplify();
        }
        public void add(int number)
        {
            digits[9] += number;
            this.simplify();
        }
        public string getDigits()
        {
            string value = "";
            foreach(int digit in digits)
            {
                value += digit;
            }
            return value;
        }
        static void Main(string[] args)
        {
            Problem97 prog = new Problem97(28433);

            for (int i = 0; i < 7830457; i++) // 2^7830457
            {
                prog.multiply(2);
            }

            prog.add(1);

            Console.WriteLine("Answer = " + prog.getDigits());
            Console.ReadKey();
        }
    }
}
