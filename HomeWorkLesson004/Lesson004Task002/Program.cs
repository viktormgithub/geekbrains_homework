using System;

namespace Lesson004Task002
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите строку из чисел, разделенных пробелами");
            var input = Console.ReadLine();

            if (!ValidateInput(input))
            {
                Console.WriteLine("Ошибка! Некорректный ввод");
                return;
            }

            Console.WriteLine(SummNumbersFromString(input!));
        }

        private static bool ValidateInput(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            for (var i = 0; i < input.Length; i++)
            {
                var item = input[i];

                //коды симвоов: пробел 32,
                //Цифры: 0 - 48, 9 - 57
                if (item == 32 || 48 <= item && item <= 57)
                    continue;

                return false;
            }

            return true;
        }

        private static int SummNumbersFromString(string input)
        {
            var sumNumbers = 0;

            var currentNumberString = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                var item = input[i];

                if (item != ' ')
                    currentNumberString += item;

                if (item == ' ' || i == input.Length - 1)
                {
                    if (int.TryParse(currentNumberString, out var inputNumber))
                    {
                        sumNumbers += inputNumber;
                    }

                    currentNumberString = string.Empty;
                }
            }

            return sumNumbers;
        }
    }
}