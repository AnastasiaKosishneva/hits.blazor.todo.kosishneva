using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<TaskItem>().HasData([
            new() { Id = 1, Product = "Футболка", Category = "одежда", Order = "252 покупки"},
            new() { Id = 2, Product = "Джинсы", Category = "одежда", Order = "1000 покупок" },
            new() { Id = 3, Product = "Куртка", Category = "верхняя одежда", Order = "2 покупки"},
			new() {Id = 4, Product = "Задача 4", Category = "Описание задачи 4", Order = "2 покупки"},
			]);
		}
	}
}
