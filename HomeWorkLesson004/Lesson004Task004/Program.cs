using System;

namespace Lesson004Task004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое значение для вычисления числа Фибоначчи");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int n) )
            {
                Console.WriteLine("Ошибка! Некорректное значение при вводе");
                return;
            }
            
            //TODO if для отрицательных

            Console.WriteLine("Число Фибоначчи равно: " + GetFibonachiNumber(n));
        }

        static int GetFibonachiNumber(int n)
        {
            if (n is 0 or 1)
            {
                return n;
            }

            return GetFibonachiNumber(n - 1) + GetFibonachiNumber(n - 2);
        }
    }
}