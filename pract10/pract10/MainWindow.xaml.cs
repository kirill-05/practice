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

namespace pract10
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

        Random random = new Random();

        List<int> mas = new List<int>();

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                mas.Add(random.Next(-100, 100));
                mainList.Items.Add(mas[i]);
            }
        }

        private void Switch_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            for(int i = 0; i < mas.Count; i++)
            {
                if (mas[a] < mas[i])
                    a = i;
            }
            _ = (mas[0], mas[a] = mas[a], mas[0]);
            MessageBox.Show($"Наибольшее число поменялось местами с первым {mas[a]} {mas[0]}");
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \n" +
                "В массиве чисел найти наибольший элемент и поменять его местами с первым элементом.", "О программе" , MessageBoxButton.OK);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            mainList.Items.Clear();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
