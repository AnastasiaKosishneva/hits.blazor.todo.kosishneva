using System.Collections;
//интерфейс, который вернуть может инт. нас объектов
namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync(); //вернуть
        Task SaveAsync(TaskItem taskitem);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
        Task<IEnumerable<TaskItem>> SearchAsync(string query);
    }
}

