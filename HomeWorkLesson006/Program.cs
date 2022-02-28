using System.Diagnostics;

namespace HomeWorkLesson006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] allProcesses = Process.GetProcesses();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("{0,-30} {1, 5}", "Process", "PID");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < allProcesses.Length; i++)
            {
                Console.WriteLine("{0,-30} {1, 5}", allProcesses[i].ProcessName, allProcesses[i].Id);
            }

            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Введите числом PID либо буквами имя процесса для завершения");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int pid))
            {
                try
                {
                    Process processById = Process.GetProcessById(pid);
                    processById.Kill();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: некорректное значение PID");
                    Console.WriteLine("Детали ошибки: " + e.Message);
                }

                return;
            }


            try
            {
                Process[] arrProcessByName = Process.GetProcessesByName(input);

                if (arrProcessByName.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка! Процесс {input} остуствует");
                    return;
                }

                foreach (var process in arrProcessByName)
                {
                    process.Kill();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка:" + e.Message);
            }
        }
    }
}