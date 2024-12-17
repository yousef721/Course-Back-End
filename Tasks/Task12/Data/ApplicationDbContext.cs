using Microsoft.EntityFrameworkCore;
using Task12.Models;

namespace Task12.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=192.168.100.43;User Id=SA;Password=reallyStrongPwd123;Initial Catalog=ToDoCRUD;TrustServerCertificate=True");
        }
    }
}
