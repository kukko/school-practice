using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School
    {
        private string name;
        private ArrayList students = new ArrayList();
        public School(string name)
        {
            this.name = name;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public ArrayList GetStudents()
        {
            return students;
        }
        public void PrintDescription()
        {
            Console.WriteLine(name);
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("\t" + ((Student)students[i]).GetDescription());
            }
        }
    }
}
