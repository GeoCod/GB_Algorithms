using System;

namespace Algorithms
{
    /// <summary>Класс вспомогательных функций</summary>
    public class Verification
    {
        /// <summary>Запрос значения "Int" через консоль с проверкой на тип значения</summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public static int GetInt(string msg)
        {
            bool flag; int number;
            do
            {
                flag = Int32.TryParse(Console.ReadLine(), out number);
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(msg);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            } while (!flag);  // Пока false(!false=true), повторять цикл
            return number;
        }

        /// <summary>Запрос значения "Double" через консоль с проверкой на тип значения</summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public static double GetDouble(string msg)
        {
            bool flag; double number;
            do
            {
                flag = double.TryParse(Console.ReadLine(), out number);
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(msg);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            } while (!flag);  // Пока false(!false=true), повторять цикл
            return number;
        }
    }
}
