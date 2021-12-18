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
using System.Windows.Threading;

namespace pract12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Content = d.ToString("HH:mm");
            date.Content = d.ToString("dd.MM.yyyy");
        }

        private void CalculateFirst_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(InputFirst.Text);
            int b = Int32.Parse(InputSecond.Text);
            if (a > 0 && b > 0)
            {
                firstResult.Text = Math.Round(Math.Sqrt(a * b), 2).ToString();
            }
            else
                MessageBox.Show("Вы ввели отрицательное число");
        }

        private void CalculateSecond_Click(object sender, RoutedEventArgs e)
        {
            int a , b, c;
            int threeNumber = Int32.Parse(ThreeDigitNumber.Text);
            a = threeNumber % 10;
            threeNumber /= 10;
            b = threeNumber % 10;
            threeNumber /= 10;
            c = threeNumber;
                     
            inputThreeDigitNumber.Text = (b * 100 + c * 10 + a).ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \n" +
                "Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения. \n" +
                " Дано трехзначное число.Вывести число, полученное при перестановке цифр сотени десятков исходного числа(например, 123 перейдет в 213");
        }

        private void InputFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstResult.Clear();
            InputSecond.Clear();
        }

        private void ThreeDigitNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            inputThreeDigitNumber.Clear();
        }

    }
}
