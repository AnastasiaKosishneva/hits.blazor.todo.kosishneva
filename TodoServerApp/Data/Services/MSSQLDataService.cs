using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    //    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    //    {
    //        public async Task<IEnumerable<TaskItem>> GetAllAsync()
    //        {
    //            return await context.TaskItems.ToArrayAsync();
    //        }

    //        public async Task SaveAsync(TaskItem taskItem)
    //        {
    //            await context.SaveChangesAsync();
    //        }

    //        public async Task<TaskItem> GetTaskAsync(int id)
    //        {
    //            return await context.TaskItems.FirstAsync(x => x.Id == id);
    //        }

    //        public async Task DeleteAsync(int id)
    //        {
    //            var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
    //            context.TaskItems.Remove(taskItem);
    //            await context.SaveChangesAsync();
    //        }
    //    }
    //}public class MSSQLDataService : IDataService
    public class MSSQLDataService : IDataService
    {
        private readonly ApplicationDbContext context;

        public MSSQLDataService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await context.TaskItems.ToListAsync();
        }

        public async Task<TaskItem> GetTaskAsync(int id)
        {
            return await context.TaskItems.FirstOrDefaultAsync(t => t.Id == id)
                ?? new TaskItem();
        }

        public async Task SaveAsync(TaskItem taskItem)
        {
            if (taskItem.Id == 0)
            {
                context.TaskItems.Add(taskItem);
            }
            else
            {
                context.TaskItems.Update(taskItem);
            }
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var taskItem = await context.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            if (taskItem != null)
            {
                context.TaskItems.Remove(taskItem);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TaskItem>> SearchAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return await GetAllAsync();
            }

            return await context.TaskItems
                .Where(t => t.Product.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                            t.Category.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }
    }

}
