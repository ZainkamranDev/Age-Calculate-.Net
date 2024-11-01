using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result
{
    internal class Class1
    {

        private static int current_year = 2024;
        private static int birth_year = 2006;


        public int calculate_age()
        {



            int age = current_year - birth_year;
            return age;
        }
    }
}