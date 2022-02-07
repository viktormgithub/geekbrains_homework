using System;

namespace Lesson003Task004
{
    class Program
    {
        static void Main()
        {
            // Квадрат
            char[,] arrSeeBattle = new char[10, 10];

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    arrSeeBattle[x, y] = 'O';
                }
            }

            // Корабли
            for (int p = 3; p < 7; p++)
            {
                arrSeeBattle[p, 1] = 'X';
                arrSeeBattle[1, p] = 'X';
                arrSeeBattle[8, p] = 'X';
            }

            Console.ForegroundColor = ConsoleColor.Green;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (arrSeeBattle[x, y] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    Console.Write(arrSeeBattle[x, y] + "  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine();
            }
        }
    }
}