using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolStorage
    {
        private static List<School> schools = new List<School>();
        public static void AddSchool(School school)
        {
            schools.Add(school);
        }
        public static List<School> GetSchools()
        {
            return schools;
        }
        public static void PrintSchools()
        {
            for (int i = 0; i < schools.Count; i++)
            {
                schools[i].PrintDescription();
            }
        }
    }
}
