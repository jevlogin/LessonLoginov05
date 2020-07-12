using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder str = new StringBuilder("Площадь");
                PrintString(str);

                str.Append(" треугольника равна");
                PrintString(str);

                str.AppendFormat(" {0:f2}", 123.456);
                PrintString(str);

                str.Insert(8, "данного ");
                PrintString(str);

                str.Remove(7, 21);
                PrintString(str);

                str.Replace("а", "о");
                PrintString(str);

                Console.WriteLine("Введите первую строку для сравнения");
                StringBuilder str1 = new StringBuilder(Console.ReadLine());

                Console.WriteLine("Введите вторую строку для сравнения");
                StringBuilder str2 = new StringBuilder(Console.ReadLine());

                Console.WriteLine($"Строки равны: {str1.Equals(str2)}");
            }
            catch (Exception)
            {
                Console.WriteLine("Возникло исключение");
            }

            Console.ReadKey();
        }

        private static void PrintString(StringBuilder str)
        {
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Текущая длина строки: {str.Length}");
            Console.WriteLine($"Объем буфера: {str.Capacity}");
            Console.WriteLine($"Максимальный объем буфера: {str.MaxCapacity}");
            Console.WriteLine();
        }
    }
}
