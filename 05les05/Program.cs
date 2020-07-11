using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello!";
            string s2 = "Hello!";
            Console.WriteLine(String.Compare(s1, s2));
            Console.WriteLine(s1.CompareTo(s2));

            Console.ReadKey();
        }
    }
}
