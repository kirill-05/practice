 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using Lib_6;
using Lib_Mas;
using My_array;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] mas;

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Int32.TryParse(stolb.Text, out int Count) == true)
                {
                    Mas.CreateArray(out mas, Count);
                    DataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Неверное значение", "Ошибка");
            }
        }

        private void fill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Int32.TryParse(diapazon1.Text, out int nachDiapoz) == true && Int32.TryParse(diapazon2.Text, out int konDiapoz) == true && Int32.TryParse(stolb.Text, out int Count) == true)
                {
                    Mas.FillArray(out mas, nachDiapoz, konDiapoz, Count);
                    DataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное значение", "Ошибка");
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mas != null)
                {
                    sum.Text = Convert.ToString(Practice.Sum(mas));
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Некорректные данные", "Ошибка");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (mas != null)
            {
                Mas.ClearArray(ref mas);
                DataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            stolb.Clear();
            diapazon1.Clear();
            diapazon2.Clear();
            sum.Clear();
           
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Mas.SaveArray(mas);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Mas.OpenArray(out mas);
            DataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \nВвести n целых чисел. Найти сумму чисел < 15. Результат вывести на экран", "О программе" , MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Clock(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
