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

namespace pract7
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int Number1 = Int32.Parse(value1.Text);
            int Number2 = Int32.Parse(value2.Text);
            int Number3 = Int32.Parse(value3.Text);
            MessageBox.Show($"{Number1 + Number2 + Number3}", "Сумма Триады");
        }


        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \nИспользовать класс Triad (тройка положительных чисел)." +
                "Разработать операции определения равенства / неравенства чисел true / false." +
                "Разработать операции проверки полного равенства / неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2). ",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
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
            first.Clear();
            second.Clear();
            third.Clear();

        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            Triad FirstTriad = new Triad(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text));
            Triad SecondTriad = new Triad(int.Parse(first.Text), int.Parse(second.Text), int.Parse(third.Text));
            Triad resultTriad = FirstTriad = SecondTriad;
            MessageBox.Show($"{FirstTriad.IsEqual(SecondTriad)}", "Равенство триад", MessageBoxButton.OK);

        }

        private void CalculateArea_Click(object sender, RoutedEventArgs e)
        {
            int Number1 = Int32.Parse(value1.Text);
            int Number2 = Int32.Parse(value2.Text);
            int Number3 = Int32.Parse(value3.Text);
            MessageBox.Show($"{Triangle.GetArea(Number1 ,Number2 , Number3)}", "Площадь треугольника");
        }


        private void CalculateCorner_Click(object sender, RoutedEventArgs e)
        {
            int Number1 = int.Parse(value1.Text);
            int Number2 = int.Parse(value2.Text);
            int Number3 = int.Parse(value3.Text);
            MessageBox.Show($"{Triangle.GetCorner(Number1,Number2,Number3)}" , "Угол треугольника");
        }
    }
}
