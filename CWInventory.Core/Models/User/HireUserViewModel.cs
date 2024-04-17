using CWInventory.Core.Models.Storage;

namespace CWInventory.Core.Models.User
{
    public class HireUserViewModel
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        
        public int? StorageId { get; set; }

        public IEnumerable<StorageViewModel>Storages { get; set; } = new List<StorageViewModel>();
    }
}
