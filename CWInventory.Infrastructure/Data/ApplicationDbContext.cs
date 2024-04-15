using CWInventory.Infrastructure.Data.Models;
using CWInventory.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CWInventory.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StoragesProducts>()
                .HasKey(sp => new { sp.StorageId, sp.ProductId });

            builder.Entity<StoragesProducts>()
                .HasOne(sp => sp.Product)
                .WithMany(sp => sp.Storages)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Document>()
                .HasOne(d => d.Creator)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Document>()
                .HasOne(d => d.Storage)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.ApplyConfiguration(new CateogryConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<StoragesProducts> StoragesProducts { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
    }
}
