using System;
using System.Text.RegularExpressions;

namespace _05les09
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]{2,6}");
            Console.WriteLine(regex.IsMatch("jev.login@mail.ru"));
            Console.WriteLine(regex.IsMatch("jev.login@mail"));
            Console.WriteLine(regex.IsMatch("jev.login"));

            Console.ReadKey();
        }
    }
}
