using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13
{
    class Practice
    {
        public static int LastColumn(int[,] matrix)
        {
            int firstCount;
            int lastCount;
            int equalColumn = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                firstCount = 0;
                lastCount = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] > 0)
                    {
                        firstCount++;
                    }
                    else if (matrix[j, i] < 0)
                    {
                        lastCount++;
                    }
                }
                if (firstCount == lastCount)
                {
                    equalColumn = i + 1;
                }
            }
            return equalColumn;
        }
    }
}
