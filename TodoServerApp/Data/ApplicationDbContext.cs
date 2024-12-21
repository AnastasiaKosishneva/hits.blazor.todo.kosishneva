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
            new() { Id = 1, Product = "��������", Category = "������", Order = "252 �������"},
            new() { Id = 2, Product = "������", Category = "������", Order = "1000 �������" },
            new() { Id = 3, Product = "������", Category = "������� ������", Order = "2 �������"},
			new() {Id = 4, Product = "������ 4", Category = "�������� ������ 4", Order = "2 �������"},
			]);
		}
	}
}
