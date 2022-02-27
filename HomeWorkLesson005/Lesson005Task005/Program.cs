using System.Text.Json;

namespace Lesson005Task005
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ToDo.CreateFakeTasksJsonFile();

            if (!File.Exists(ToDo.FileName))
            {
                Console.WriteLine($"Ошибка! Отсутствует файл {ToDo.FileName}");
                return;
            }

            var fileString = File.ReadAllText(ToDo.FileName);
            var todoList = JsonSerializer.Deserialize<ToDo[]>(fileString);

            if (todoList == null)
            {
                Console.WriteLine("Ошибка! Массив null");
                return;
            }

            while (true)
            {
                for (int i = 0; i < todoList.Length; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Console.WriteLine(todoList[i]);
                }

                Console.WriteLine("Введите номер выполенной задачи");
                Console.WriteLine("Для выхода введите exit");
                var input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(input, out var isDoneNumber) ||
                    isDoneNumber > todoList.Length)
                {
                    Console.WriteLine("Ошибка! Некорректный ввод номера задачи");
                    return;
                }

                var index = isDoneNumber - 1;
                todoList[index].IsDone = true;

                fileString = JsonSerializer.Serialize(todoList);
                File.WriteAllText(ToDo.FileName, fileString);
            }
        }
    }
}