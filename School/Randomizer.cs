using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Randomizer
    {
        private static Random random = new Random();
        public static int GetRandomNumber()
        {
            return random.Next();
        }
        public static int GetRandomNumber(int max)
        {
            return random.Next(max);
        }
        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
