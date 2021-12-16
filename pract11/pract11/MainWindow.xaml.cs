using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pract11
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
        
        string first = "aa aba abba abbba abca abea";
        string second = "a2a a4a ab3a ca2d ba7a a6a ab6a";

        private void find_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("(aa|aba)");
            MatchCollection matches = regex.Matches(first);
            Object[] regexA = new Object[matches.Count];
            matches.CopyTo(regexA, 0);
            firstList.ItemsSource = regexA;
            
        }

        private void findS_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("(\\ba[3-7]a\\b)");
            MatchCollection matches = regex.Matches(second);
            Object[] regexB = new object[matches.Count];
            matches.CopyTo(regexB, 0);
            secondList.ItemsSource = regexB;
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 \n" +
                "Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, которое найдет строки aa, aba. \n" +
                "Напишите регулярное выражение, которое найдет строки следующего вида: покраям стоят буквы 'a', а между ними - цифра от 3 - х до 7 - ми");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            firstList.Items.Clear();
            secondList.Items.Clear();
        }
    }
}
