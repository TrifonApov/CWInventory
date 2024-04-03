using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CWInventory.Infrastructure.Data.SeedDb
{
    internal class CateogryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[]
                {
                    data.PaperCategory,
                    data.GarbageBagCategory,
                    data.CleaningAgentCategory,
                    data.DisinfectantCategory,
                    data.DetergentCategory,
                    data.MedicalCategory,
                    data.CarDetergentCategory
                });
        }
    }
}
