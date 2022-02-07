using System;

namespace Lesson002Task001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру `C");
            string? inputMinTemp = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру `C");
            string? inputMaxTemp = Console.ReadLine();

            bool resultMinCorrect = float.TryParse(inputMinTemp, out float minTemp);
            bool resultMaxCorrect = float.TryParse(inputMaxTemp, out float maxTemp);

            if (!resultMinCorrect || !resultMaxCorrect)
            {
                Console.WriteLine("Ошибка! Ввели некорректные данные");
                return;
            }

            if ( minTemp > maxTemp)
            {
                Console.WriteLine("Ошибка! Минимальная температура выше максимальной");
                return;
            }

            float resultAvrTemp = (maxTemp + minTemp) / 2;
            
            Console.WriteLine($"Cредняя температура {Math.Round(resultAvrTemp, 1, MidpointRounding.AwayFromZero)}`C");
            Console.Write("\n");
            Console.WriteLine("Результат получен с точностью 1 знак после запятой");
            Console.ReadLine();
        }
    }
}