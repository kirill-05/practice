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

namespace pract8
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

        protected int Number;
        List<Student> array = new List<Student>();
        protected int index;


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(studentName.Text, studentSurname.Text, studentPatronimy.Text, Convert.ToInt32(studentAge.Text), studentGender.Text, Groups.Text);
            array.Add(student);
            mainList.Items.Add(student.GetInfo());
            
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            index = mainList.SelectedIndex;
            if (index >= 0)
            {
                Student student = (Student)array[index];
                Student newStudent = (Student)student.Clone();
                array[Number] = newStudent;
                mainList.Items.Add(newStudent.GetInfo());
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            index = mainList.SelectedIndex;
            if (index >= 0)
            {
                mainList.Items.RemoveAt(index);
                array.RemoveAt(index);
            }
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            int equalSurname = 0;
            int Results;
            index = mainList.SelectedIndex;
            if (index >= 0)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (i != index)
                    {
                       Results = array[index].CompareTo(array[i]);
                    }
                }
                MessageBox.Show("Количество студенстов с одинаковой фамилией - " + equalSurname , "Сравнение по фамилии.");
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Махмудов Кирилл ИСП-34 Создать интерфейсы – человек и печать (для формирования информации об объекте). \n " +
                "Создать класс – студент.Класс должен включать конструкторы функциюдля формирования строки информации о студенте. \n" +
                "Сравнение производить по фамилии.", "О программе", MessageBoxButton.OK);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
