using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин:");
            Console.WriteLine(LoginCheck(Console.ReadLine()));
            Console.ReadKey();
        }

        static string LoginCheck(string log)
        {
            Regex pattern = new Regex(@"^[A-Za-z]{1}[A-Za-z0-9]{1,9}$");
            return pattern.IsMatch(log) ? "Логин соответствует" : "Логин не соответствует";
        }
    }
}
