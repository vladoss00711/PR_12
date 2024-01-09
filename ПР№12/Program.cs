//**********************************************************
//* Практическая работа №12                                *
//* Выполнил: Архипов В.И., группа 2-ИСП-22-оКФ            *
//* Задание: Основные структуры языка: символы и строки.   *
//**********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ПР_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Практическая работа №12");
                    Console.WriteLine("Здравствуйте!");
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    string result = ConvertCase(input);
                    Console.WriteLine("Результат: " + result);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                string ConvertCase(string input)
                {
                    string result = "";

                    foreach (char c in input)
                    {
                        if (char.IsLower(c))
                            result += char.ToUpper(c);
                        else if (char.IsUpper(c))
                            result += char.ToLower(c);
                        else
                            result += c;
                    }
                    return result;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Спасибо,до свидания!");
                Console.ReadKey();
            }
        }
    }
}

