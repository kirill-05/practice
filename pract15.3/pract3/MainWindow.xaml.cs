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
using lib_6;
using lib_mas;
using Microsoft.Win32;


namespace pract3
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
        CalculateMatrix calculateMatrix = new CalculateMatrix();
        private int[,]  matrix;

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isNEmpty = Int32.TryParse(inputA.Text, out int n);
                bool isMEmpty = Int32.TryParse(inputB.Text, out int m);
                if (isNEmpty && isMEmpty && n > 0 && m > 0)
                {
                    matrix = matrixArray.Generate(n, m);
                    DataGridA.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные числа", "Ошибка");
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {

            if (matrix != null)
                result.Text = string.Join(";", calculateMatrix.Sum(matrix));
            else MessageBox.Show("Сгенерируйте таблицу", "Ошибка" , MessageBoxButton.OK);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
            inputA.Clear();
            inputB.Clear();
           
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34\n" +
                "Дана матрица размера M × N. Для каждого столбца матрицы с четным номером (2, 4, …) найти сумму его элементов." +
                "Условный оператор не использовать.", "О программе", MessageBoxButton.OK) ;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    }
}
