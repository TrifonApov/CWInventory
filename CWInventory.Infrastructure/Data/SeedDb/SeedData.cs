using CWInventory.Infrastructure.Data.Models;

namespace CWInventory.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public Category PaperCategory { get; set; }
        public Category GarbageBagCategory { get; set; }
        public Category CleaningAgentCategory { get; set; }
        public Category DisinfectantCategory { get; set; }
        public Category DetergentCategory { get; set; }
        public Category MedicalCategory { get; set; }
        public Category CarDetergentCategory { get; set; }

        public SeedData()
        {
            SeedCategories();
        }

        private void SeedCategories()
        {
            PaperCategory = new Category() { Id = 1, Name = "Paper" };

            GarbageBagCategory = new Category() { Id = 2, Name = "GarbageBag" };

            CleaningAgentCategory = new Category() { Id = 3, Name = "Cleaning Agent" };

            DisinfectantCategory = new Category() { Id = 4, Name = "Disinfectant" };

            DetergentCategory = new Category() { Id = 5, Name = "Detergent" };

            MedicalCategory = new Category() { Id = 6, Name = "Medical" };

            CarDetergentCategory = new Category() { Id = 7, Name = "Car Detergent" };
        }

    }
}
