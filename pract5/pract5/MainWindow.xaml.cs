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

namespace pract5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Triad triad = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(value1.Text);
            int b = Int32.Parse(value2.Text);
            int c = Int32.Parse(value3.Text);
            triad.SetParams(a, b, c);
            OutSum.Text = triad.Sum().ToString();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \nСоздать класс Triad (тройка положительных чисел). " +
                " Создать необходимые методы и свойства.Определить метод вычисления суммы чисел. " +
                "Создать перегруженные методы SetParams, для установки параметров объекта" ,"О программе" , MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            value1.Clear();
            value2.Clear();
            value3.Clear();
            OutSum.Clear();
        }
    }
}
