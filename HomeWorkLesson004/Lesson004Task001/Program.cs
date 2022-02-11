using System;

namespace Lesson004Task001
{
    internal static class Program
    {
        private static void Main()
        {
            (string? lastName, string? firstName, string? patronymic)[] userInput = GetUserInput();

            if (!ValidateInput(userInput))
            {
                Console.WriteLine("Ошибка! Некорректный ввод данных");
                return;
            }

            for (var i = 0; i < userInput.Length; i++)
            {
                var (lastName, firstName, patronymic) = userInput[i];

                var fullName = GetFullName(firstName, lastName, patronymic);

                Console.WriteLine(fullName);
            }
        }

        private static (string? firstName, string? lastName, string? patronymic)[] GetUserInput()
        {
            Console.WriteLine("Введите количество пользователей");

            var count = Convert.ToInt32(Console.ReadLine());

            var users = new (string lastName, string firstName, string patronymic)[count];

            for (var i = 0; i < users.Length; i++)
            {
                users[i] = GetUserName(i)!;
            }

            return users!;
        }

        private static string GetFullName(string? firstName, string? lastName, string? patronymic)
        {
            var result = string.Empty;

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                result += lastName;
            }

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                if (!string.IsNullOrWhiteSpace(result))
                    result += " ";

                result += firstName;
            }

            if (!string.IsNullOrWhiteSpace(patronymic))
            {
                if (!string.IsNullOrWhiteSpace(result))
                    result += " ";

                result += patronymic;
            }

            return result;
        }

        private static (string? firstName, string? lastName, string? patronymic) GetUserName(int i)
        {
            Console.WriteLine($"Введите ФАМИЛИЮ пользователя {i + 1}");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Введите ИМЯ пользователя {i + 1}");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Введите ОТЧЕСТВО пользователя {i + 1}");
            var patronymic = Console.ReadLine();

            return (lastName, firstName, patronymic);
        }

        private static bool ValidateInput((string? lastName, string? firstName, string? patronymic)[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var (lastName, firstName, patronymic) = input[i];

                if (string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(patronymic))
                    return false;
            }

            return true;
        }
    }
}