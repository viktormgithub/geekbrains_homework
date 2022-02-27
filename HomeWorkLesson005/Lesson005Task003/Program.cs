using System;
using System.IO;

namespace Lesson005Task003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "Lesson005Task003.bin";

            Console.WriteLine("Введите значение: сколько чисел записать в бинарный файл?");
            int count = Convert.ToInt32(Console.ReadLine());

            byte[] arrNumbers = new byte[count];

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число 0-255");
                string? inputElement = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputElement)
                    || Convert.ToInt32(inputElement) < 0
                    || Convert.ToInt32(inputElement) > 255)
                {
                    Console.WriteLine("Ошибка! Значение должно быть 0-255");
                    return;
                }

                arrNumbers[i] = Convert.ToByte(inputElement);
            }

            Console.WriteLine($"Набор чисел записан в файл {filename}");

            File.WriteAllBytes(filename, arrNumbers);
        }
    }
}