using System;

namespace Lesson003Task001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Размерность массива
            int arrDimension = 10;
            int[,] myArray = new int[arrDimension, arrDimension];
            
            int count = 1;

            // заполняем исходный  массив 
            for (int y = 0; y < arrDimension; y++)
            {
                for (int x = 0; x < arrDimension; x++)
                {
                    myArray[x, y] = count++;
                }
            }
            
            // выводим исходный маcсив
            Console.WriteLine("Исходный массив:");
            
            for (int y = 0; y < arrDimension; y++)
            {
                for (int x = 0; x < arrDimension; x++)
                {
                    Console.Write(myArray[x, y] + "   ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------" + "\n");
            
            // диагональ 1
            Console.WriteLine("Выводим массив по диагонали слева-направо:");
            for (int i = 0; i < arrDimension; i++)
            {
                Console.Write(myArray[i, i] + "  ");
            }

            Console.WriteLine("\n" + "--------------------------------");
            
            // диагональ 2
            Console.WriteLine("Выводим массив по диагонали справа-налево:");
            for (int i = 0; i < arrDimension; i++)
            {
                Console.Write(myArray[arrDimension - i -1, i] + "  ");
            }

            Console.ReadKey();
        }
    }
}