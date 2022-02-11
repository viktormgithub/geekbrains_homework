using System;

namespace Lesson004Task003
{
    class Program
    {
        [Flags]
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 12");
            string? input = Console.ReadLine();

            (bool result, string errorMessage, int? number) = ValidateInput(input);
            if (!result)
            {
                Console.WriteLine(errorMessage);
                return;
            }
            
            var seasonEnum = GetSeasonEnumByMonthNumber(number!.Value);
            string text = GetRussianTextByEnum(seasonEnum);

            Console.WriteLine(text);
        }

        static (bool result, string errorMessage, int? resNumber) ValidateInput(string input)
        {
            bool result = true;
            string errorMessage = string.Empty;

            if (!int.TryParse(input, out int number) || number < 1 || number > 12)
            {
                result = false;
                errorMessage = "Ошибка: введите число от 1 до 12";
            }

            return (result, errorMessage, number);
        }

        static Season GetSeasonEnumByMonthNumber(int number)
        {
            Season season = 0;

            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    season = Season.Winter;
                    break;

                case 3:
                case 4:
                case 5:
                    season = Season.Spring;
                    break;

                case 6:
                case 7:
                case 8:
                    season = Season.Summer;
                    break;

                case 9:
                case 10:
                case 11:
                    season = Season.Autumn;
                    break;
            }

            return season;
        }

        static string GetRussianTextByEnum(Season season)
        {
            string result = string.Empty;

            switch (season)
            {
                case Season.Winter:
                    result = "Зима";
                    break;
                
                case Season.Spring:
                    result = "Весна";
                    break;
                
                case Season.Summer:
                    result = "Лето";
                    break;

                case Season.Autumn:
                    result = "Осень";
                    break;
            }

            return result;
        }
    }
}