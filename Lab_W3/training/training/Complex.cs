using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace training
{
    [Serializable]
    public class Complex
    {
        public int c1, c2;
        public Complex()
        {
            c1 = 0;
            c2 = 0;
        }

        public Complex(int _c1, int _c2)
        {
            c1 = _c1;
            c2 = _c2;
        }

        public static int NOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            int NOK = (a.c2 * b.c2) / (NOD(a.c2, b.c2));
            a.c1 = (NOK / a.c2) * a.c1;
            b.c1 = (NOK / b.c2) * b.c1;
            Complex ans = new Complex(a.c1 + b.c1, NOK);
            return ans;

        }

        public void Simplify()
        {
            int NOK = NOD(c1, c2);
            c1 /= NOK;
            c2 /= NOK;
        }
        public override string ToString()
        {
            return c1 + "/" + c2;
        }
    }

}
