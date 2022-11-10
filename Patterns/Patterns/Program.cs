using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            string userInput;
            do
            {
                Console.Write("Введите целое положительное число N для расчета (для выхода введите 'q'):");
                userInput = Console.ReadLine();
                if (userInput == "q") break;
                if (int.TryParse(userInput, out int numberN))
                {
                    Console.WriteLine();
                    if (numberN < 21) 
                        Console.WriteLine($"Факториал числа {numberN} равен: {Fact(numberN)}");
                    else
                        Console.WriteLine($"Факториал посчитать не удалось, введите число меньше 21");
                    Console.WriteLine($"Сумма от 1 до {numberN} равна: {Sum(numberN)}");
                    Console.WriteLine($"Максимальное четное число меньше {numberN} равно: {Max(numberN)}");
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Не верный формат");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (true);
        }

        #region Функции
        /// <summary>
        /// Расчет факториала числа
        /// </summary>
        static long Fact(long num) => (num == 0) ? 1   :   (num < 0) ? 0 : num * Fact(num - 1);

        /// <summary>
        /// Подсчет суммы чисел от 1 до N
        /// </summary>
        static long Sum(long num) => (num < 0) ? 0 : num * (1 + num) / 2;

        /// <summary>
        /// Максимальное четное число меньше N
        /// </summary>
        static long Max(long num) => (num % 2 == 0) ? num - 2 : num - 1;

        #endregion
    }
}
