using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6
{
    class Triad
    {

        public Triad(int number1, int number2, int number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }

        public int Number1 { get; set;}
        public int Number2 { get; set; }
        public int Number3 { get; set; }

        
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
