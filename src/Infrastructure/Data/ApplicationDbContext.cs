using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.OwnsOne(e => e.Price, navigationBuilder =>
                {
                    navigationBuilder.Property(p => p.Amount).HasColumnName("Price_Amount");
                    navigationBuilder.Property(p => p.Currency).HasColumnName("Price_Currency");
                });

                entity.Property(e => e.Category)
                      .HasConversion<string>(); // To store enum as string
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
