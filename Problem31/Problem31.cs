using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem31
{
    class Coins : IEquatable<Coins>
    {
        int p1, p2, p5, p10, p20, p50, p100, p200;
        public Coins(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            p1 = a;
            p2 = b;
            p5 = c;
            p10 = d;
            p20 = e;
            p50 = f;
            p100 = g;
            p200 = h;
        }
        public bool Equals(Coins other)
        {
            return this.p1 == other.p1 &&
                this.p2 == other.p2 &&
                this.p5 == other.p5 &&
                this.p10 == other.p10 &&
                this.p20 == other.p20 &&
                this.p50 == other.p50 &&
                this.p100 == other.p100 &&
                this.p200 == other.p200;
        }
    }
    class Problem31
    {
        static void Main(string[] args)
        {
            int MAX = 200;

            List<Coins> valid = new List<Coins>();
            for (int p1 = 0; p1 <= MAX; p1++)
            {
                for (int p2 = 0; p2 <= MAX - p1; p2 += 2)
                {
                    for (int p5 = 0; p5 <= MAX - p2 - p1; p5 += 5)
                    {
                        for (int p10 = 0; p10 <= MAX - p5 - p2 - p1; p10 += 10)
                        {
                            for (int p20 = 0; p20 <= MAX - p10 - p5 - p2 - p1; p20 += 20)
                            {
                                for (int p50 = 0; p50 <= MAX - p20 - p10 - p5 - p2 - p1; p50 += 50)
                                {
                                    for (int p100 = 0; p100 <= MAX - p50 - p20 - p10 - p5 - p2 - p1; p100 += 100)
                                    {
                                        for (int p200 = 0; p200 <= MAX - p100 - p50 - p20 - p10 - p5 - p2 - p1; p200 += 200)
                                        {
                                            int number = p1 + p2 + p5 + p10 + p20 + p50 + p100 + p200;
                                            if (number == 200)
                                            {
                                                Coins change = new Coins(p1, p2, p5, p10, p20, p50, p100, p200);
                                                if (!valid.Contains(change))
                                                {
                                                    valid.Add(change);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Answer = " + valid.Count);
            Console.ReadKey();
        }
    }
}
