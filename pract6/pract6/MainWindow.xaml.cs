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

namespace pract6
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
            int a = Convert.ToInt32(value1.Text);
            int b = Convert.ToInt32(value2.Text);
            int c = Convert.ToInt32(value3.Text);
            Triad triad1 = new Triad(a, b, c);
            MessageBox.Show($"{triad1.Number1 + triad1.Number2 + triad1.Number3}", "Сумма чисел");
        }


        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \nИспользовать класс Triad (тройка положительных чисел)." +
                "Разработать операции определения равенства / неравенства чисел true / false." +
                "Разработать операции проверки полного равенства / неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2). " ,
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
            First.Clear();
            Second.Clear();
            third.Clear();

        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            Triad FirstTriad = new Triad(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text));
            Triad SecondTriad = new Triad(int.Parse(First.Text), int.Parse(Second.Text), int.Parse(third.Text));
            MessageBox.Show($"{FirstTriad.IsEqual(SecondTriad)}" ,"Равенство триад", MessageBoxButton.OK);

        }
    }
}
