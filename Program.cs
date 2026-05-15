using TodoApp.Models;
using TodoApp.Services;

var todoService = new TodoService();
todoService.LoadTodos();

while (true)
{
    Console.WriteLine("\n=== Todo App ===");
    Console.WriteLine("1. Add Todo");
    Console.WriteLine("2. View Todos");
    Console.WriteLine("3. Mark Complete");
    Console.WriteLine("4. Delete Todo");
    Console.WriteLine("5. Save and Exit");
    Console.Write("Choose option: ");
    
    var choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            Console.Write("Enter title: ");
            var title = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty!");
                break;
            }
            
            Console.Write("Enter description: ");
            var description = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Description cannot be empty!");
                break;
            }
            
            todoService.AddTodo(title, description);
            Console.WriteLine("Todo added!");
            break;
            
        case "2":
            Console.WriteLine("\n=== Your Todos ===");
            var todos = todoService.GetAllTodos();
            
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos yet!");
            }
            else
            {
                foreach (var todo in todos)
                {
                    var status = todo.IsComplete ? "Done" : "Pending";
                    
                    var output =
                        "[" + todo.Id + "] " +
                        todo.Title + " - " +
                        todo.Description + " (" +
                        status + ")";
                        
                    Console.WriteLine(output);
                }
            }
            
            break;
            
        case "3":
            Console.Write("Enter todo ID to mark complete: ");
            
            if (int.TryParse(Console.ReadLine(), out int completeId))
            {
                todoService.MarkTodoComplete(completeId);
                Console.WriteLine("Todo marked as complete!");
            }
            else
            {
                Console.WriteLine("Invalid ID!");
            }
            
            break;
            
        case "4":
            Console.Write("Enter todo ID to delete: ");
            
            if (int.TryParse(Console.ReadLine(), out int deleteId))
            {
                todoService.DeleteTodo(deleteId);
                Console.WriteLine("Todo deleted!");
            }
            else
            {
                Console.WriteLine("Invalid ID!");
            }
            
            break;
            
        case "5":
            todoService.SaveTodos();
            Console.WriteLine("Todos saved. Goodbye!");
            return;
    }
}
