using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Storage;

namespace CWInventory.Core.Services
{
    public class StorageService : IStorageService
    {
        public Task<IEnumerable<StorageViewModel>> AllStoragesAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(CreateStorageViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<StorageViewModel> Details(int storageId)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(CreateStorageViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
