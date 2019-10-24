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
        private static ArrayList schools = new ArrayList();
        public static void AddSchool(School school)
        {
            schools.Add(school);
        }
        public static ArrayList GetSchools()
        {
            return schools;
        }
        public static void PrintSchools()
        {
            for (int i = 0; i < schools.Count; i++)
            {
                ((School)schools[i]).PrintDescription();
            }
        }
    }
}
