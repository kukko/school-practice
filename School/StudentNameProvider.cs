using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentNameProvider
    {
        private static string[] names = new string[] { "Emilly", "Gábor", "Judit", "Levente", "Géza", "Míra", "Kevin", "Józsi", "Spongyabob", "Darth Vader", "Luke Skywalker", "Neo", "Gandalf", "Frodó", "Samu" };
        public static string GetRandomStudentName()
        {
            return names[Randomizer.GetRandomNumber(0, names.Length)];
        }
    }
}
