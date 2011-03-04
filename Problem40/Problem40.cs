using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem40
{
    class Problem40
    {
        static void Main(string[] args)
        {
            int count = 1;
            int digits = 0;
            int product = 1;
            while (digits <= 1000000)
            {
                string number = "" + count;
                
                // 123 becomes 1, 2, 3
                foreach (char c in number)
                {
                    digits++;
                    int num = int.Parse(""+c);
                    switch (digits)
                    {
                        case 1:
                        case 10:
                        case 100:
                        case 1000:
                        case 10000:
                        case 100000:
                        case 1000000:
                            product *= num;
                            break;
                    }
                }
                count++;
            }
            Console.WriteLine("Answer = " + product);
            Console.ReadKey();
        }
    }
}
