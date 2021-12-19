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
using Microsoft.Win32;
using System.Data;
using lib_mas;
using System.Windows.Threading;

namespace pract13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        MatrixArray matrixArray = new MatrixArray();
        Practice lastCount = new Practice();
        private int[,] matrix;

        private void find_Click(object sender, RoutedEventArgs e)
        {
            
            DataGridA.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            result.Text = Practice.LastColumn(matrix).ToString();
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            bool isNEmpty = Int32.TryParse(inputRow.Text, out int n);
            bool isMEmpty = Int32.TryParse(inputColum.Text, out int m);
            matrix = matrixArray.Generate(n, m);
            DataGridA.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            DataGridA.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            inputColum.Clear();
            inputRow.Clear();
            result.Clear();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            matrixArray.Save(matrix);
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            matrixArray.Open(matrix);
            DataGridA.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \n" +
                "Дана целочисленная матрица размера M * N. Найти номер последнего из ее \n" +
                "столбцов, содержащих равное количество положительных и отрицательных элементов(нулевые элементы матрицы не учитываются). \n" +
                "Если таких столбцов нет,то вывести 0", "О программе");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "123")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
