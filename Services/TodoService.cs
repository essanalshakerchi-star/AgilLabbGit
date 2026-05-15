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

        public void MarkTodoComplete(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);

            if (todo != null)
            {
                todo.IsComplete = true;
            }
        }

        public void DeleteTodo(int id)
        {
            todos.RemoveAll(t => t.Id == id);
        }

        public void SaveTodos()
        {
        }

        public void LoadTodos()
        {
        }
    }
}
