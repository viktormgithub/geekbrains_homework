using System.Text;
using System.Text.Json;

namespace Lesson005Task005;

public class ToDo
{
    public const string FileName = "tasks.json";
    public string? Title { get; set; }

    public bool IsDone { get; set; }

    // При выводе в консоль
    public override string ToString()
    {
        var str = new StringBuilder();
        str.Append(IsDone ? "[x]" : "[ ]")
            .Append(" Задача: ")
            .Append(Title);
        return str.ToString();
    }

    public static void CreateFakeTasksJsonFile()
    {
        var todoList = new[]
        {
            new ToDo() {Title = "Task 1", IsDone = true},
            new ToDo() {Title = "Task 2", IsDone = false},
            new ToDo() {Title = "Task 3", IsDone = false},
            new ToDo() {Title = "Task 4", IsDone = true},
            new ToDo() {Title = "Task 5", IsDone = false},
        };

        // Аналогично этому
        // var todo2 = new Todo();
        // todo2.Title = "Task2";

        var json = JsonSerializer.Serialize(todoList); // превращает обьект в строку
        File.WriteAllText(FileName, json);
    }
}