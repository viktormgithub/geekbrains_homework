using System;

namespace Lesson002Task002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = "";

            Console.WriteLine("Введите номер месяца");
            string? inputNumberOfMonth = Console.ReadLine();


            bool result = int.TryParse(inputNumberOfMonth, out var number);

            if (!result)
            {
                Console.WriteLine("Ошибка! Некорректное значение при вводе");
                return;
            }

            switch (number)
            {
                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
                default:
                    month = " с некорректным номером. Такого месяца не существует.";
                    break;
            }

            Console.WriteLine($"Это месяц {month}");
            Console.ReadLine();
        }
    }
}