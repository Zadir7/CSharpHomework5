using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку для сравнения:");
            string userString1 = Console.ReadLine();
            Console.WriteLine("Введите первую строку для сравнения:");
            string userString2 = Console.ReadLine();
            Console.WriteLine(isAnagramm(userString1,userString2));

            Console.ReadKey();
        }

        static string isAnagramm(string str1, string str2)
        {
            if (str1 == str2) { return "Строки одинаковы! Вы нас обманули!"; }

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            if (ch1.Length == ch2.Length)
            {
                Array.Sort(ch1);
                Array.Sort(ch2);
            }
            else { return "Строки неравны по длине и не могут быть перевертышем!"; }

            return ch1.ToString() == ch2.ToString() ? "Строка 2 является перестановкой строки 1" : "Строка 2 не является перестановкой строки 1";
        }
    }
}
