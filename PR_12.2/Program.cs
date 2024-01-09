using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_12._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Практическая работа №12.2\nЗдравствуйте!", Console.ForegroundColor = ConsoleColor.Green);
            try
            {
                do
                {
                    Console.Write("Введите число: ");
                    string number = Console.ReadLine();
                    string reversedNumber = ReverseNumber(number);
                    Console.WriteLine("Число в обратном порядке: " + reversedNumber);
                } while
                       (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message, Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        static string ReverseNumber(string num)
        {
            if (num.Length <= 1)
                return num;
            else
                return num[num.Length - 1] + ReverseNumber(num.Substring(0, num.Length - 1));
        }
    }
}