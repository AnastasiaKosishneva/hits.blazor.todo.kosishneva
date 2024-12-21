//реал. интерфейс
using System.Collections;
using System.Data;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService //реал.
    {
        public static IEnumerable<TaskItem> Tasks { get; } =
        [

            new() { Id=1, Product="Футболка", Category="одежда", Order = "252 покупки"},
            new() { Id=2, Product="Джинсы", Category="одежда",Order = "1000 покупок"},
            new() { Id=3, Product = "Куртка", Category = "верхняя одежда", Order = "2 покупки"},
        ];
        private readonly List<TaskItem> _tasks = new();
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskItem>> GetTaskItemAsync()
        {
            return Task.FromResult(Tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
        public Task AddAsync(TaskItem task)
        {
            // Генерация нового ID
            task.Id = _tasks.Count > 0 ? _tasks.Max(t => t.Id) + 1 : 1;

            _tasks.Add(task);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<TaskItem>> SearchAsync(string query)
        {
            throw new NotImplementedException();
        }
    }
}
