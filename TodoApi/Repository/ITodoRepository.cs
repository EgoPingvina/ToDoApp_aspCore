
using System.Collections.Generic;

using TodoApi.Models;

namespace TodoApi.Repository
{
    public interface ITodoRepository
    {
        public void Add(TodoItem item);

        public IEnumerable<TodoItem> GetAll();

        public TodoItem Find(string key);

        public TodoItem Remove(string key);

        public void Update(TodoItem item);
    }
}