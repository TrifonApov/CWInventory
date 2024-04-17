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
                .WithMany(c=>c.Documents)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Document>()
                .HasOne(d => d.Storage)
                .WithMany(s => s.Documents)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.Entity<Manager>()
                .HasOne(m => m.Storage)
                .WithOne(m => m.Manager)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ApplyConfiguration(new CateogryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserClaimsConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<StoragesProducts> StoragesProducts { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
    }
}
