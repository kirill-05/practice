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

namespace pract9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Subjects subjects1;
        Subjects subjects2;
        Subjects subjects3;
        Subjects subjects4;
        Subjects subjects5;

        Subjects[] subjectsArray;
        List<Subjects> Audience = new List<Subjects>();

        public MainWindow()
        {
            InitializeComponent();
        }

        struct Subjects
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymi { get; set; }
            public string Subject { get; set; }
            public string AudienceNumber { get; set; }
            public int Hours { get; set; }

            public Subjects(string surname, string name , string patronymi, string subject, string audienceNumber, int hours)
            {
                Surname = surname;
                Name = name;
                Patronymi = patronymi;
                Subject = subject;
                AudienceNumber = audienceNumber;
                Hours = hours;

            }
        }

        private void subject_Click(object sender, RoutedEventArgs e)
        {
            subjects1 = new Subjects("Новицкий", "Кирилл", "Викторович", "РПМ", "24", 94);
            subjects2 = new Subjects("Качковсикй", "Юрий", "Валентинович", "ПМО", "21", 50);
            subjects3 = new Subjects("Осипова", "Виктория", "Валерьевна", "ИСБУ", "30",68);
            subjects4 = new Subjects("Щупова", "Татьяна", "Вячеславовна", "Теория Вероятности", "40", 60);
            subjects5 = new Subjects("Самусенко","Мария", "Витальевна", "МДК 04.01", "26" , 60);
            mainList.Items.Add($"{subjects1.Surname} {subjects1.Name} {subjects1.Patronymi}, предмет: {subjects1.Subject}, аудитория: {subjects1.AudienceNumber}, {subjects1.Hours} часов в семестре");
            mainList.Items.Add($"{subjects2.Surname} {subjects2.Name} {subjects2.Patronymi}, предмет: {subjects2.Subject}, аудитория: {subjects2.AudienceNumber}, {subjects2.Hours} часов в семестре");
            mainList.Items.Add($"{subjects3.Surname} {subjects3.Name} {subjects3.Patronymi}, предмет: {subjects3.Subject}, аудитория: {subjects3.AudienceNumber}, {subjects3.Hours} часов в семестре");
            mainList.Items.Add($"{subjects4.Surname} {subjects4.Name} {subjects4.Patronymi}, предмет: {subjects4.Subject}, аудитория: {subjects4.AudienceNumber}, {subjects4.Hours} часов в семестре");
            mainList.Items.Add($"{subjects5.Surname} {subjects5.Name} {subjects5.Patronymi}, предмет: {subjects5.Subject}, аудитория: {subjects5.AudienceNumber}, {subjects5.Hours} часов в семестре");
        }

        private void lecturer_Click(object sender, RoutedEventArgs e)
        {
            subjectsArray = new [] { subjects1, subjects2, subjects3, subjects4, subjects5 };
            string a = inputAudience.Text;
            for(int i = 0; i < subjectsArray.Length; i++)
            {
                if (subjectsArray[i].AudienceNumber.Contains(a))
                    MessageBox.Show($"Преподаватель {subjectsArray[i].Surname} {subjectsArray[i].Name} {subjectsArray[i].Patronymi} кабинет {subjectsArray[i].AudienceNumber}");
            }

            

        }
    }
}
