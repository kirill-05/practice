using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6
{
    class Triad
    {
        private int number1;
        private int number2;
        private int number3;

        public int Number1
        {

            get
            {
                return number1;
            }

            set
            {

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else number1 = value;
            }
        }


        public int Number2
        {

            get
            {
                return number2;
            }

            set
            {

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else number2 = value;
            }
        }


        public int Number3
        {

            get
            {
                return number3;
            }

            set
            {

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else number3 = value;
            }
        }

        public int Sum()
        {
            return Number1 + Number2 + Number3;
        }

        public void SetParams(int newNumber)
        {
            Number1 = newNumber;
            Number2 = newNumber;
            Number3 = newNumber;
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
}
