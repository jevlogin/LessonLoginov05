using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05les03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Первая строка";
            string str2 = string.Copy(str1);
            string str3 = "Вторая строка";
            string str4 = "ВТОРАЯ строка";
            string strUp, strLow;
            int result, idx;
            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"Длина строки str1: {str1.Length}");
            strLow = str1.ToLower();
            strUp = str1.ToUpper();
            Console.WriteLine($"Строчная версия строки str1: {strLow}");
            Console.WriteLine($"Прописная версия строки str1: {strUp}");
            Console.WriteLine();

            result = str1.CompareTo(str3);
            if (result == 0)
            {
                Console.WriteLine($"str1 и str3 равны.");
            }
            else if (result < 0)
            {
                Console.WriteLine($"str1 меньше чем str3");
            }
            else
            {
                Console.WriteLine($"str1 больше чем str3");
            }
            result = String.Compare(str3, str4, true);
            if (result == 0)
            {
                Console.WriteLine("str3 и str4 равны без учета регистра");
            }
            else
            {
                Console.WriteLine("str3 и str4 не равны без учета регистра");
            }
            Console.WriteLine();

            result = String.Compare(str1, 4, str2, 4, 2);
            if (result == 0)
            {
                Console.WriteLine("часть str1 и str2 равны");
            }
            else
            {
                Console.WriteLine("часть str1 и str2 не равны");
            }
            Console.WriteLine();

            idx = str2.IndexOf("строка");
            Console.WriteLine($"Индекс первого входения подстроки строки: {idx}");
            idx = str2.LastIndexOf("о");
            Console.WriteLine($"Индекс последнего вхождения символа о: {idx}");

            string str = String.Concat(str1, str2, str3, str4);
            Console.WriteLine(str);

            str = str.Remove(0, str1.Length);
            Console.WriteLine(str);

            str = str.Replace("строка", "");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
