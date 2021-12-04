using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7
{
    class Triangle : Triad
    {



        public double GetArea(int a, int b ,  int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S == Convert.ToDouble(S) ? S : throw new ArgumentException();

        }

        public double GetCorner(int a,int b ,int c)
        {
            double f = Math.Round(Math.Acos(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) / 2 * a * b), 5);
            return f == Convert.ToDouble(f) ? f : throw new ArgumentException();
        }
    }
}
