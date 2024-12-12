using Microsoft.EntityFrameworkCore;
using Task11.Models;

namespace Task11.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=192.168.100.43;User Id=SA;Password=reallyStrongPwd123;Initial Catalog=Hospital;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasData(new List<Doctor>
            {
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
                new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
                new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
            });
        }
    }
}
