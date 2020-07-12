using System;
using System.Text;

/**
 * 
 * На практике часто комбинируют работу с изменяемыми и неизменяемыми строками. 
 * Если необходимо изменять строку, используют StringBuilder.
 * 
 * */


namespace _05les0702
{
    class Program
    {
        const int iIterations = 10_000;
        static void Main(string[] args)
        {
            // Сравним производительность работы StringBuilder с неизменяемыми строками:

            #region String

            //DateTime dt = DateTime.Now;
            //string str = string.Empty;
            //for (int i = 0; i < iIterations; i++)
            //{
            //    str += "abcdefghijklmnopqrstuvwxyz\r\n";
            //}
            //Console.WriteLine(DateTime.Now - dt);

            //00:00:00.3849929

            #endregion


            #region StringBuilder
            //  Те же операции с StringBuilder:

            DateTime dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iIterations; i++)
            {
                sb.Append("abcdefghijklmnopqrstuvwxyz\r\n");
            }
            string str = sb.ToString();
            Console.WriteLine(DateTime.Now - dt);

            //00:00:00.0009739      Как видим, тут быстрее )

            #endregion

            Console.ReadKey();
        }
    }
}
