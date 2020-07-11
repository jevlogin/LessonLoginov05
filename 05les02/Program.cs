using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les02
{
    class Program
    {
        static void PrintArray(string line, char[] a)
        {
            Console.WriteLine(line);
            foreach (var el in a)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine('\n');
        }
        static void Main(string[] args)
        {
            char[] a = { 'm', 'a', 'X', 'i', 'M', 'u', 'S', '!', '!' };
            char[] b = "кол окол колокола".ToCharArray();
            PrintArray("Исходный массив a:", a);
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsLower(a[i]))
                {
                    a[i] = char.ToUpper(a[i]);
                }
            }
            PrintArray("Измененный массив a:", a);
            PrintArray("Исходный массив b:", b);
            Array.Reverse(b);
            PrintArray("Измененный массив b:", b);

            //  Создание строк
            string s; // инициализация отложена


            string s2 = "Колпак на колпаке, под колпаком колпак"; // инициализация строковым литералом

            string s3 = @"http://
                        geekbrains.ru";
            // символ @ сообщает конструктору string, что строку
            // нужно воспринимать буквально, даже если она занимает несколько строк

            string s4 = new string(' ', 20); // конструктор создает строку из 20 пробелов

            int x = 123456789;
            // инициализировали целочисленную переменную

            string s5 = x.ToString();
            // преобразовали ее к типу string

            char[] a2 = { 'a', 'b', 'c', 'd', 'e' };
            // создали массив символов

            string v = new string(a); // создание строки из массива символов

            char[] a3 = { 'a', 'b', 'c', 'd', 'e' };

            // создание строки из части массива символов, при этом:  0

            string v2 = new string(a3, 0, 2);
            // показывает с какого символа, 2 – сколько символов использовать для  инициализации



            Console.ReadKey();
        }
    }
}
