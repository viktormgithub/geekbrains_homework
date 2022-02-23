using System;

namespace Lesson003Task003
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string? inputString = Console.ReadLine();

            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("Ошибка! Пустая строка на входе");
                return;
            }
            
            Console.Write("Эта строка в обратном порядке: ");
            
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
        }
    }
}