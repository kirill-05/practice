using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8
{
    public class Student : IHuman, IPrint, ICloneable, IComparable
    {
        

        public Student(string studentName, string studentSurname, string studentPatronimy, int studentAge, string studentGender, string studentGroup)
        {
            GetName = studentName;
            GetSurname = studentSurname;
            GetPatronimy = studentPatronimy;
            GetAge = studentAge;
            GetGender = studentGender;
            GetGroup = studentGroup;
        }

        public string GetName { get ; set; }
        public string GetSurname { get ; set; }
        public string GetPatronimy { get ; set ; }
        public string GetGender { get ; set ; }
        public int GetAge { get ; set; }
        public string GetGroup { get; set; }

        public object Clone()
        {
            Student student = new Student(this.GetName, this.GetSurname, this.GetPatronimy, this.GetAge, this.GetGender, this.GetGroup);

            return student;
        }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.GetSurname.Length > student.GetSurname.Length) return 1;
            if (this.GetSurname.Length < student.GetSurname.Length) return -1;
            return 0;
        }

        public string GetInfo()
        {
            return GetSurname + " " + GetName + " " + GetPatronimy + "\n " +
                " Возраст: " + GetAge.ToString() + "; Пол: " + GetGender[0] + "." + "\n " +
                " Группа: " + GetGroup;
        }
    }
}
