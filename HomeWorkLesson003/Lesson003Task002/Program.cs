using System;

namespace Lesson003Task002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrEmailBook = new string[5, 2]
            {
                {"Даня Милохин", "danya@milohin.com"},
                {"Ольга Арбузова", "olga@arbuzova.com"},
                {"Николай Басков", "nikolay@baskov.ru"},
                {"Стас Михайлов", "stas@mihailov.ru"},
                {"Филип Киркоров", "filip@kirkorov.ru"},
            };

            Console.WriteLine("Emails ContactBook:");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < arrEmailBook.GetLength(0); i++)
            {
                Console.WriteLine("Person: " + arrEmailBook[i, 0] + " | " + "email: " + arrEmailBook[i, 1]);
            }
        }
    }
}