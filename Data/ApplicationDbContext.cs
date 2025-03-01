using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
         : base(options) 
         {
         }
         //use the TaskItem class
         public DbSet<TaskItem> Tasks { get; set; }
    }
}