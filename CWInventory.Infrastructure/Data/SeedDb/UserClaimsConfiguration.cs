using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CWInventory.Infrastructure.Data.SeedDb
{
    internal class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            var data = new SeedData();

            builder.HasData(data.AdminUserClaim);
        }
    }
}
