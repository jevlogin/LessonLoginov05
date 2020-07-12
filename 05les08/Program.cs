using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05les08
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = "Петра, Андрей, Николай";
            string data2 = "Петр, Андрей, Александр";
            Regex regex = new Regex("Николай"); //  Создание регулярного выражения
            Console.WriteLine(regex.IsMatch(data1));
            Console.WriteLine(regex.IsMatch(data2));

            Console.ReadKey();
        }
    }
}
