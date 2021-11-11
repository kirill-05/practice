using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Forms;

namespace Lib_Mas
{
    public class Mas
    {
        public static void CreateArray(out int[] mas, int Count)
        {
            mas = new int[Count];
        }
        public static void FillArray(out int[] mas, int FirsCount, int SecondCount, int Count)
        {
            mas = new int[Count];
            Random Rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Rand.Next(FirsCount, SecondCount);
                if (mas[i] == 0) i++;
            }
        }
        public static void ClearArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++) mas[i] = 0;
        }
        public static void SaveArray(int[] mas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            if (mas != null)
            {
                if (save.ShowDialog() > 0)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.WriteLine(mas.Length);
                    for (int i = 0; i < mas.Length; i++)
                        file.WriteLine(mas[i]);
                    file.Close();
                }
            }
            else MessageBox.Show("Таблица пуста", "Ошибка");
        }
        public static void OpenArray(out int[] mas)
        {
            mas = new int[1];
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";
            DialogResult dialogResult = open.ShowDialog();
            bool f1 = Convert.ToBoolean(dialogResult);
            if (f1 == true)
            {
                StreamReader file = new StreamReader(open.FileName);
                int len = Convert.ToInt32(file.ReadLine());
                mas = new Int32[len];
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = Convert.ToInt32(file.ReadLine());
                file.Close();
            }
        }
    }
}
