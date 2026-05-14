using TodoApp.Models;
using System.Text.Json;

namespace TodoApp.Services
{
    public class TodoService
    {
        private List<Todo> todos = new List<Todo>();
        private int nextId = 1;

        public void AddTodo(string title, string description)
        {
            var todo = new Todo
            {
                Id = nextId++,
                Title = title,
                Description = description,
                IsComplete = false,
                CreatedAt = DateTime.Now
            };
            todos.Add(todo);
        }

        public List<Todo> GetAllTodos()
        {
            return todos;
        }

        public void DeleteTodo(int id)
        {
            todos.RemoveAll(t => t.Id == id);
        }

        public void SaveTodos()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(todos, options);
            File.WriteAllText("todos.json", json);
        }

        public void LoadTodos()
        {
            if (File.Exists("todos.json"))
            {
                var json = File.ReadAllText("todos.json");
                todos = JsonSerializer.Deserialize<List<Todo>>(json) ?? new List<Todo>();
                if (todos.Count > 0)
                {
                    nextId = todos.Max(t => t.Id) + 1;
                }
            }
        }
    }
}
