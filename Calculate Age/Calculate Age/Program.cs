using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 age1 = new Class1();
            Console.WriteLine(age1.calculate_age());
            Console.ReadLine();
        }
    }
}
