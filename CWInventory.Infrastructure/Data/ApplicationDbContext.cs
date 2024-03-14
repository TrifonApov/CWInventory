using CWInventory.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CWInventory.Infrastrucure.Data
{
    public class ApplicationDbContext : IdentityDbContext
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
