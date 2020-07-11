using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les06
{
    class Program
    {
        static void Main(string[] args)
        {
            // создание пустой строки, размер по умолчанию 16 символов
            StringBuilder a = new StringBuilder();
            // инициализация строки и выделение необходимой памяти
            StringBuilder b = new StringBuilder("abcd");
            // создание пустой строки и выделение памяти под 100 символов
            StringBuilder c = new StringBuilder(100);
            // инициализация строки и выделение памяти под 100 символов 
            StringBuilder d = new StringBuilder("bcde", 100);
            // инициализация подстроки "bcd" и выделение памяти под 100 символов	
            StringBuilder e = new StringBuilder("abcd", 1, 3, 100);

            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
