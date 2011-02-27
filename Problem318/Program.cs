using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Runtime.InteropServices;
/*
Consider the real number 2+3.
When we calculate the even powers of 2+3 we get:
(2+3)^2 = 9.898979485566356...
(2+3)^4 = 97.98979485566356...
(2+3)^6 = 969.998969071069263...
(2+3)^8 = 9601.99989585502907...
(2+3)^10 = 95049.999989479221...
(2+3)^12 = 940897.9999989371855...
(2+3)^14 = 9313929.99999989263...
(2+3)^16 = 92198401.99999998915...
It looks like that the number of consecutive nines at the beginning of the fractional part of these powers is non-decreasing.
In fact it can be proven that the fractional part of (sqrt 2 + sqrt 3)^2n approaches 1 for large n.

Consider all real numbers of the form sqrt p + sqrt q with p and q positive integers and p<q, such that the fractional part of (sqrt p+ sqrt q)^2n approaches 1 for large n.

Let C(p,q,n) be the number of consecutive nines at the beginning of the fractional part of 
(sqrt p + sqrt q)^2n.

Let N(p,q) be the minimal value of n such that C(p,q,n) >=  2011.

Find N(p,q) for p+q  2011.
*/
namespace Problem318
{

    class Program
    {
        static void Main(string[] args)
        {
            PrecisionSpec ps = new PrecisionSpec(10000,PrecisionSpec.BaseType.DEC);
            
            BigInteger j = 0;
            int MAX = 2100;
            for (int q = 3; q <= MAX; q++)
            {
                for (int p = 2; p < q; p++)
                {
                    if (p + q > MAX) break;
                    int count = 0;
                    int n = 0;
                    int last = 0;
                    int max = 0;
                    while (count <= MAX)
                    {
                        if (n > 2 && last == 0 ) break;
                        last = count;
                        count = 0;

                        BigFloat bigp = new BigFloat(p, ps);
                        BigFloat bigq = new BigFloat(q, ps);
                        BigFloat bigvalue = BigFloat.Pow(BigFloat.Sqrt(bigp) + BigFloat.Sqrt(bigq), 2 * ++n);
                        
                        string[] breakup = bigvalue.ToString().Split('.');
                        if (breakup.Length != 1)
                        {
                            string dec = breakup[1];


                            for (int i = 0; i < dec.Length; i++)
                            {
                                if (dec[i] == '9')
                                {
                                    count++;
                                    if (count > max) max = count;
                                    //Console.WriteLine(p + " " + q + " = " + count);
                                }
                                else
                                {
                                    if (count == 0)
                                    {

                                    }
                                    break;
                                }
                            }

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(p + " " + q + " max = " + max);

                }
                
            }
            Console.ReadKey();
        }
    }
}
