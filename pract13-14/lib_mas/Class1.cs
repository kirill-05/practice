using Microsoft.Win32;
using System;
using System.Data;
using System.IO;

namespace lib_mas
{
    public static class VisualArray
    {
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("Col" + (i + 1));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }
    }

    public class MatrixArray
    {
        private Random random = new Random();
        private int[,] matrix;

        public int[,] Generate(int lengthA, int lengthB, int min = -100, int max = 100)
        {
            matrix = new int[lengthA, lengthB];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(min, max);
                }
            }
            return matrix;
        }

        public int[,] Open(int[,] matrix)
        {
            OpenFileDialog reader = new OpenFileDialog();
            reader.DefaultExt = ".txt";
            if (reader.ShowDialog() == true)
            {
                StreamReader read = new StreamReader(reader.FileName);
                matrix = new int[Convert.ToInt32(read.ReadLine()), Convert.ToInt32(read.ReadLine())];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = Convert.ToInt32(read.ReadLine());
                    }
                }
            }
            return matrix;
        }

        public void Save(int[,] matrix)
        {
            SaveFileDialog writer = new SaveFileDialog();
            writer.DefaultExt = ".txt";

            if (writer.ShowDialog() == true)
            {
                StreamWriter write = new StreamWriter(writer.FileName);
                write.WriteLine(matrix.GetLength(0));
                write.WriteLine(matrix.GetLength(1));
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        write.WriteLine(matrix[i, j]);
                    }
                }
                write.Close();
            }
        }

        public void ClearMatrix(int max = 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(max);
                }
            }
        }
    }
    }
