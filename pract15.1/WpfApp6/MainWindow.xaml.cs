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
using Lib_6;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var number = Practice.СomputationValues();
                generated.Text = number.numbers;
                result.Text = number.sqrt.ToString();
                outvalue.Text = number.pow.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \n Генерировать случайные числа Х, распределенные в диапазоне от -5 до 4 и вычислять для чисел > 0 X, а для чисел < 0 функцию x^2. " +
                "Вычисленияпрекратить, когда подряд появится два одинаковых случайных числа.  " +
                "На экраннеобходимо выводить сгенерированное число и результат расчета функции наразных строках.", "О программе", MessageBoxButton.OK);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void generated_TextChanged(object sender, TextChangedEventArgs e)
        {
            result.Clear();
            outvalue.Clear();
        }
    }
}
