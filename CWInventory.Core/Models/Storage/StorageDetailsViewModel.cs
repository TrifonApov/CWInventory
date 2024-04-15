using CWInventory.Infrastructure.Data.Models;


namespace CWInventory.Core.Models.Storage
{
    public class StorageDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ManagerId { get; set; } = string.Empty;

        public string Manager { get; set; } = string.Empty;

        public ICollection<string> Employees { get; set; } = new List<string>();

        public ICollection<string> Products { get; set; } = new List<string>();
    }
}
