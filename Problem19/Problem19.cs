using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem19
{
    class Problem19
    {
        static void Main(string[] args)
        {
            int count = 0;

                DateTime dt = new DateTime(1901, 1, 1);
                while (dt.Year <= 2000)
                {
                    dt = dt.AddMonths(1);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        if (dt.Day == 1) count++;
                    }
                }
            // <3 datetime class
            Console.WriteLine("Answer = " + count);
            Console.ReadKey();
        }
    }
}
