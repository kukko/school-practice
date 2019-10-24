using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string name;
        private int classs;
        private List<int> grades = new List<int>();
        private bool graduated = false;
        public Student(string name)
        {
            this.name = name;
            this.classs = 1;
        }
        public Student(string name, int classs)
        {
            this.name = name;
            this.classs = classs;
        }
        public string GetDescription()
        {
            string output = name + " => " + classs + " " + (graduated ? "Érettségizett" : "Iskolás");
            output += " " + String.Join(", ", grades);
            return output;
        }
        public void RaiseClass()
        {
            if (classs < 12)
            {
                classs++;
                return;
            }
            graduated = true;
        }
        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }
    }
}
