using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
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
                    throw new ArgumentException("Введите положительное число");
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
                    throw new ArgumentException("Введите положительное число");
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
                    throw new ArgumentException("Введите положительное число");
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
    }
}
