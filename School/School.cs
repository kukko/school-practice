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
        private List<Student> students = new List<Student>();
        public School(string name)
        {
            this.name = name;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void PrintDescription()
        {
            Console.WriteLine(name);
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("\t" + students[i].GetDescription());
            }
        }
    }
}
