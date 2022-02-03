using System;

namespace Lesson002Task005
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagIsWinter = false;
            bool flagIsZeroUp = false;

            Console.WriteLine("Введите порядковый номер месяца");
            string? inputMonthNumber = Console.ReadLine();

            bool inputMonthCorrect = int.TryParse(inputMonthNumber, out int intMonthNumber);

            if (!inputMonthCorrect || intMonthNumber <= 0 || intMonthNumber > 12)
            {
                Console.WriteLine("Ошибка! Некорректный ввод данных");
                return;
            }

            switch (intMonthNumber)
            {
                case 12:
                case 1:
                case 2:
                    flagIsWinter = true;
                    break;
                default:
                    flagIsWinter = false;
                    break;
            }

            Console.WriteLine("Введите минимальную температуру `C");
            string? inputMinTemp = Console.ReadLine();

            Console.WriteLine("Введите максимальную температуру `C");
            string? inputMaxTemp = Console.ReadLine();

            bool inputMinCorrect = float.TryParse(inputMinTemp, out float minTemp);
            bool inputMaxCorrect = float.TryParse(inputMaxTemp, out float maxTemp);

            if (!inputMinCorrect || !inputMaxCorrect)
            {
                Console.WriteLine("Ошибка! Ввели некорректные данные");
                Console.ReadLine();
                return;
            }

            if (minTemp > maxTemp)
            {
                Console.WriteLine("Ошибка! Минимальная температура выше максимальной");
                Console.ReadLine();
                return;
            }

            float resultAvrTemp = (maxTemp + minTemp) / 2;
            if (resultAvrTemp > 0)
            {
                flagIsZeroUp = true;
            }


            if (flagIsWinter && flagIsZeroUp)
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadLine();
            }
        }
    }
}