using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;

namespace P01_SalesDatabase.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Store> Stores { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Data Source=localhost;User Name=SA;Password=reallyStrongPwd123;Initial Catalog=SalesDb;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // ID Tables
        modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
        modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
        modelBuilder.Entity<Sale>().HasKey(s => s.SaleId);
        modelBuilder.Entity<Store>().HasKey(s => s.StoreId);
        
        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasColumnType("varchar(50)")
            .IsUnicode(true);
        modelBuilder.Entity<Customer>()   
            .Property(c => c.Name)   
            .HasColumnType("varchar(100)")
            .IsUnicode(true);

        modelBuilder.Entity<Customer>()   
            .Property(c => c.Email)   
            .HasColumnType("varchar(80)")
            .IsUnicode(false);

        modelBuilder.Entity<Store>()
            .Property(s => s.Name)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}