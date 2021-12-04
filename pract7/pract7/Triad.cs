using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7
{
    class Triad
    {
        public Triad(int number1, int number2, int number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }

        public int Sum()
        {
            return Number1 + Number2 + Number3;
        }


        public void SetParams(int newNumber1, int newNumber2, int newNumber3)
        {
            Number1 = newNumber1;
            Number2 = newNumber2;
            Number3 = newNumber3;
        }

        public bool IsEqual()
        {
            return Number1 == Number2 && Number2 == Number3;
        }

        public bool IsEqual(Triad anotheTraid)
        {
            bool First = Number1 == anotheTraid.Number1;
            bool Second = Number2 == anotheTraid.Number2;
            bool Third = Number3 == anotheTraid.Number3;

            return First == Second && Second == Third;
        }

        public static bool operator true(Triad triad)
        {
            if (triad.Number1 > 0 && triad.Number2 > 0 && triad.Number3 > 0)
                return true;
            else return false;
        }

        public static bool operator false(Triad triad)
        {
            return triad.Number1 <= 0 && triad.Number2 <= 0 && triad.Number3 <= 0;
        }

        public static bool operator ==(Triad triad1, Triad triad2)
        {
            return triad1.IsEqual(triad2);
        }

        public static bool operator !=(Triad triad1, Triad triad2)
        {
            return !(triad1 == triad2);
        }

    }

    class Triangle : Triad
    {

        public Triangle(int number1, int number2, int number3) : base(number1, number2, number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }

        public static double GetArea(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            if (S == Convert.ToDouble(S))
                return S;
            else
                throw new ArgumentException();

        }

        public static double GetCorner(int a, int b, int c)
        {
            double F = Math.Round(Math.Acos(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) / 2 * a * b),2);
            if (F == Convert.ToDouble(F))
                return F;
            else
                throw new ArgumentException();
        }
    }
}
