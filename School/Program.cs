using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                School school = CreateSchool();
                CreateStudentsIntoSchool(school, 3);
                SchoolStorage.AddSchool(school);
            }
            SchoolStorage.PrintSchools();
            Console.ReadKey();
        }
        static School CreateSchool()
        {
            return new School(SchoolNameTypeIn());
        }
        static string SchoolNameTypeIn()
        {
            Console.WriteLine("Mi az iskola neve?");
            return Console.ReadLine();
        }
        static void CreateStudentsIntoSchool(School school, int studentCount)
        {
            for (int j = 0; j < studentCount; j++)
            {
                school.AddStudent(CreateStudent());
            }
        }
        static Student CreateStudent()
        {
            return new Student(StudentNameTypeIn());
        }
        static string StudentNameTypeIn()
        {
            Console.WriteLine("Hogy hívják a diákot?");
            return Console.ReadLine();
        }
    }
}
