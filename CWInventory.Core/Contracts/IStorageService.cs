using CWInventory.Core.Models.Storage;

namespace CWInventory.Core.Contracts
{
    public interface IStorageService
    {
        Task<IEnumerable<StorageViewModel>> AllAsync();

        Task CreateAsync(CreateStorageViewModel model);
    }
}
