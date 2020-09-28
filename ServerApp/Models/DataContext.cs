using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany<Rating>(p => p.Ratings)
                .WithOne(r => r.Product).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasMany<Image>(p => p.Images)
                .WithOne(r => r.Product).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasOne<Blueprint>(p => p.Blueprint)
                .WithMany(s => s.Products).OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<Product>()
            //   .HasMany(c => c.Ratings)
            //   .WithOne(p => p.Product)
            //   .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Blueprint> Blueprints { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
