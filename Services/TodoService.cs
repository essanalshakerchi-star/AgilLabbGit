using TodoApp.Models;

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
    }
}
