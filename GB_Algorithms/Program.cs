using System;
using static Algorithms.Verification;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("В программе имеются следующие уроки:\n" +
                "1. Урок 1. Простые алгоритмы\n");

            int choice = GetInt("Введите номер урока:\n");

            switch (choice)
            {
                case 1:
                    Lesson01.GetMenuLesson();
                    break;

                //default:

            }
                
        }
    }
}
