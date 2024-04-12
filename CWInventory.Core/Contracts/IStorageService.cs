using CWInventory.Core.Models.Product;
using CWInventory.Core.Models.Storage;

namespace CWInventory.Core.Contracts
{
    public interface IStorageService
    {
        Task<IEnumerable<StorageViewModel>> AllStoragesAsync();

        Task CreateAsync(CreateStorageViewModel model);

        Task EditAsync(CreateStorageViewModel model);

        Task<StorageViewModel> Details(int storageId);
    }
}
