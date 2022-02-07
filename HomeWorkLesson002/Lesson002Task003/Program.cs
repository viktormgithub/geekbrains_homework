using System;

namespace Lesson002Task003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            Console.WriteLine("\n");
            Console.WriteLine("Чётность в теории чисел — характеристика целого числа // Википедия");
            string? inputNumber = Console.ReadLine();

            bool result = int.TryParse(inputNumber, out int number);

            if (!result)
            {
                Console.WriteLine("Ошибка! Некорректный ввод значения");
                return;
            }

            int devResult = number % 2;

            if (devResult == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            Console.ReadLine();
        }
    }
}