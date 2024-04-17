using CWInventory.Core.Models.Storage;
using CWInventory.Core.Models.User;

namespace CWInventory.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserDetailsViewModel>> AllAsync();

        Task<IEnumerable<StorageViewModel>> GetStorages();
        
        Task<HireUserViewModel> UserDetails(string id);

        Task HireToStorage(string userId, int storageId);
    }
}
