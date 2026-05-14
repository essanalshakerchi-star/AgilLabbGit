using TodoApp.Models;
using TodoApp.Services;

var todoService = new TodoService();

Console.WriteLine("=== Todo App ===");
Console.WriteLine("Testing US1: Add Todo\n");

Console.Write("Enter title: ");
var title = Console.ReadLine();

Console.Write("Enter description: ");
var description = Console.ReadLine();

todoService.AddTodo(title, description);

Console.WriteLine("\nTodo added successfully!");
Console.WriteLine("\nYour todos:");
var todos = todoService.GetAllTodos();
foreach (var todo in todos)
{
    Console.WriteLine($"[{todo.Id}] {todo.Title} - {todo.Description}");
}