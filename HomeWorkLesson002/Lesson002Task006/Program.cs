using System;

namespace Lesson002Task006
{
    class Program
    {
        [Flags]
        public enum Weekday
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер офиса числом от 1 до 4:");
            string? input = Console.ReadLine();

            bool inputCorrect = int.TryParse(input, out int intOfficeNumber);
            
            if (!inputCorrect)
            {
                Console.WriteLine("Ошибка! Некорректное значение при вводе");
                return;
            }

            Weekday workDaysOffice1 = Weekday.Thursday | Weekday.Friday;
            Weekday workDaysOffice2 = Weekday.Friday | Weekday.Saturday | Weekday.Sunday;
            Weekday workDaysOffice3 = Weekday.Monday | Weekday.Tuesday | Weekday.Wednesday;
            Weekday workDaysOffice4 = Weekday.Sunday;


            switch (intOfficeNumber)
            {
                case 1:
                    Console.WriteLine($"Офис #1 работает: {workDaysOffice1} ");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine($"Офис #2 работает: {workDaysOffice2} ");
                    Console.ReadLine();
                    break;
                
                case 3:
                    Console.WriteLine($"Офис #3 работает: {workDaysOffice3} ");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine($"Офис #4 работает: {workDaysOffice4} ");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Неправильный номер офиса");
                    Console.ReadLine();
                    break;
            }
        }
    }
}