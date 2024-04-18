using CWInventory.Core.Models.Storage;

namespace CWInventory.Core.Models.User
{
    public class UserDetailsViewModel
    {
        public string Id { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int? StorageId { get; set; }

        public string? StorageName { get; set; }

        public bool IsManager { get; set; }
    }
}
