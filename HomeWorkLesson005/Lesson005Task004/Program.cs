namespace Lesson005Task004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Операция: создание дерева каталогов и вложенных файлов ");
            Console.WriteLine("Создание структуры каталогов. Введите уровень вложенности 1-10:");

            int pathDepth = Convert.ToInt32(Console.ReadLine());

            // Создаем файлы и папки для урока
            // По ним будем выполнять задание
            string rootDir = @"D:\Lesson005Task004";
            string resultFile = @"D:\result.txt";
            CreateFakeFilesAndDirectoriesRecursively(pathDepth, rootDir);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Директория {rootDir} со вложенными подкаталогами создана");
            Console.WriteLine($"Итоговый файл будет создан здесь: {resultFile}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Выберите способ вычисления:");
            Console.WriteLine("1 - с рекурсией");
            Console.WriteLine("0 - без рекурсии // *не более 2 уровней вложенности");
            Console.WriteLine();


            bool inputResult = int.TryParse(Console.ReadLine(), out int inputNumber);
            if (!inputResult)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка! Некорректный ввод");
                return;
            }

            switch (inputNumber)
            {
                case 1:
                    GetFilesAndDirectoriesListRecursively(rootDir, resultFile);
                    break;
                case 0:
                    GetFilesAndDirectoriesListWithoutRecursion(rootDir, resultFile);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Введите цифру 1 или 0");
                    break;
            }
        }

        static void CreateFakeFilesAndDirectoriesRecursively(int pathDepth, string dirPath, int currentDepth = 1)
        {
            if (pathDepth == 0) return;

            //Создаем вложенную папку
            string newDirName = "subfolder" + currentDepth;
            string newPath = Path.Combine(dirPath, newDirName);
            Directory.CreateDirectory(newPath);

            // Создаем файл в папке
            string newFileName = Path.Combine(dirPath, Path.GetRandomFileName());
            File.Create(newFileName);

            pathDepth--;

            CreateFakeFilesAndDirectoriesRecursively(pathDepth, newPath, ++currentDepth);
        }

        static void GetFilesAndDirectoriesListRecursively(string dirPath, string resultFile)
        {
            GetFilesList(dirPath, resultFile);

            string[] arrDirs = Directory.EnumerateDirectories(dirPath).ToArray();
            for (int i = 0; i < arrDirs.Length; i++)
            {
                GetFilesAndDirectoriesListRecursively(arrDirs[i], resultFile);
            }
        }

        static void GetFilesAndDirectoriesListWithoutRecursion(string dirPath, string resultFile)
        {
            GetFilesList(dirPath, resultFile);

            // С разрешения преподавателя не более 2 уровней вложенности
            string[] arrDirs = Directory.EnumerateDirectories(dirPath).ToArray();
            for (int i = 0; i < arrDirs.Length; i++)
            {
                File.AppendAllLines(resultFile, new[] {"Subfolder: " + arrDirs[i]});
            }
        }

        static void GetFilesList(string dirPath, string resultFile)
        {
            File.AppendAllLines(resultFile, new[] {"Folder: " + dirPath});
            string[] arrFiles = Directory.GetFiles(dirPath);
            for (int i = 0; i < arrFiles.Length; i++)
            {
                File.AppendAllLines(resultFile, new[] {"File: " + arrFiles[i]});
            }
        }
        
    }
}