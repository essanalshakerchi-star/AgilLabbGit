using TodoApp.Models;
using TodoApp.Services;

var todoService = new TodoService();

Console.WriteLine("=== Todo App ===");

// Add first todo
Console.Write("Enter title: ");
var title1 = Console.ReadLine();

Console.Write("Enter description: ");
var description1 = Console.ReadLine();

todoService.AddTodo(title1, description1);

// Add second todo
Console.Write("Enter second title: ");
var title2 = Console.ReadLine();

Console.Write("Enter second description: ");
var description2 = Console.ReadLine();

todoService.AddTodo(title2, description2);

// Show todos
Console.WriteLine("\nYour todos:");

var todos = todoService.GetAllTodos();

foreach (var todo in todos)
{
    Console.WriteLine($"[{todo.Id}] {todo.Title} - {todo.Description}");
}

// Delete
Console.Write("\nEnter todo ID to delete: ");

if (int.TryParse(Console.ReadLine(), out int deleteId))
{
    todoService.DeleteTodo(deleteId);
}

Console.WriteLine("\nRemaining todos:");

todos = todoService.GetAllTodos();

foreach (var todo in todos)
{
    Console.WriteLine($"[{todo.Id}] {todo.Title} - {todo.Description}");
}
