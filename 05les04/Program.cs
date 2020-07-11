using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les04
{
    class Program
    {
        static void Main(string[] args)
        {
            string poems = "белеет парус одинокий в тумане моря голубом";
            char[] div = { ' ' };
            string[] parts = poems.Split(div);
            Console.WriteLine($"Результат разбиения на части: ");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
            string str = String.Join("|", parts);
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
