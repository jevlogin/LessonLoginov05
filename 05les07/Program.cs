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
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void PrintString(StringBuilder str)
        {
            Console.WriteLine(str);
        }
    }
}
