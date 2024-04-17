using CWInventory.Infrastructure.Data.Models;


namespace CWInventory.Core.Models.Storage
{
    public class StorageDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int? ManagerId { get; set; }

        public string? Manager { get; set; }

        public ICollection<string> Employees { get; set; } = new List<string>();

        public ICollection<string> Products { get; set; } = new List<string>();
    }
}
