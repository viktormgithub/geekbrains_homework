using System;
using System.IO;

namespace Lesson005Task001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка! Некорректный ввод");
                return;
            }
            
            File.WriteAllText("example.txt", input);
            
        }
    }
}