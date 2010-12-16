using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem205
{
    class Program
    {
        static double dice_prob(int value, int sides, int dice)
        {
            //int matches = 0;
            
            return value / sides;
        }
        static int roll( int sides, int dice)
        {
            Random r = new Random();
            //int matches = 0;
            int sum = 0;
            for (int i = 0; i < dice; i++)
            {
                int roll = r.Next(sides) + 1;
                if (roll == 0) throw new Exception("fuck");
                if (roll == 7) throw new Exception("cool");
                sum += roll;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            /* P(1) = 0.5
             * P(2) = 0.5
             * S(2) = P(1 & 1) = P1(2) * P2(2)
             * S(3) = P(1 & 2) = P1(1) * P2(2) + P1(2) * P1(1)
             * S(4) = P(2 & 2) = P1(2) * P2(2)
             */
            int games = 1000000;// int.MaxValue;
            int colin_wins =0, peter_wins = 0;
            Parallel.For(0, games, delegate(int i)
            //for (int i = 0; i < games; i++)
            {
                int colin = roll(6, 6);
                int peter = roll(4, 9);
                if (colin > peter)
                {
                    colin_wins++;
                }
                else if (peter > colin)
                {
                    peter_wins++;
                }

            }
            );
            Console.WriteLine("Pete won " + ((double)peter_wins / games));
            Console.ReadKey();
        }
    }
}
