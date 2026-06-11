using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class TodoDBContext :DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options)
        {
            
        }
        public DbSet<ToDoItem> TodoItems { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //configure todo item entity
            modelBuilder.Entity<ToDoItem>(entity =>
                {
                    entity.HasKey(e => e.Id);

                    entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                    entity.Property(e => e.Description)
                    .HasMaxLength(1000);

                    entity.Property(e => e.IsCompleted)
                    .HasDefaultValue(false);
                }
            );
        }
    }
}
