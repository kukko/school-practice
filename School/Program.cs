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
                CreateStudentsIntoSchool(school);
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
        static void CreateStudentsIntoSchool(School school)
        {
            CreateStudentsIntoSchool(school, Randomizer.GetRandomNumber(1, 10));
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
            Student student = new Student(StudentNameProvider.GetRandomStudentName());
            int gradeCount = Randomizer.GetRandomNumber(3, 10);
            for (int i = 0; i < gradeCount; i++)
            {
                student.AddGrade(Randomizer.GetRandomNumber(1, 6));
            }
            return student;
        }
        static string StudentNameTypeIn()
        {
            Console.WriteLine("Hogy hívják a diákot?");
            return Console.ReadLine();
        }
    }
}
