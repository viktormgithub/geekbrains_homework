using System;

namespace HomeWorkLesson001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"«Привет, {name}, сегодня {DateTime.Now}.");
            Console.ReadLine();
        }
    }
}
