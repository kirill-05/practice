using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_6
{
    public class Practice
    {
        public static  (string sqrt , string numbers, string pow) СomputationValues()
        {
            Random random = new Random();
            int value = random.Next(-5, 4);
            int s;
            int n;
            string numbers = string.Empty;
            string sqrt = string.Empty;
            string pow = string.Empty;
            double x = 0;
            do
            {

                s = value;
                value = random.Next(-5, 4);
                
                if (value > 0)
                {
                    x = Math.Sqrt(value);
                    sqrt += x.ToString() + " ";

                }
                if (value < 0)
                {
                    x = value * value;
                    pow += x.ToString() + " "; 
                }
                numbers += value.ToString() + " ";
                n = value;
            }
            while (s != n);
            return (sqrt, numbers , pow);
        }
    }
}
