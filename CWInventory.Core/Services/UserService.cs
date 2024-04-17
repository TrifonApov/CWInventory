using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Storage;
using CWInventory.Core.Models.User;
using CWInventory.Infrastructure.Data.Common;
using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CWInventory.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<UserDetailsViewModel>> AllAsync()
        {
            return await repository
                .AllReadOnly<ApplicationUser>()
                .Include(u => u.Storage)
                .Select(u => new UserDetailsViewModel()
                {
                    Id = u.Id,
                    FullName = $"{u.FirstName} {u.LastName}",
                    Email = u.Email,
                    StorageId = u.StorageId,
                    StorageName = u.Storage == null ? null : u.Storage.Name
                })
                .ToListAsync();
        }

        public async Task<HireUserViewModel> UserDetails(string id)
        {

            var model = await repository.GetByIdAsync<ApplicationUser>(id);
            var user = new HireUserViewModel();

            if (model != null)
            {
                user.Id = id;
                user.Name = $"{model.FirstName} {model.LastName}";
                user.StorageId = model.StorageId;
                user.Storages = await GetStorages();
            }

            return user;
        }

        public async Task<IEnumerable<StorageViewModel>> GetStorages()
        {
            return await repository
                .AllReadOnly<Storage>()
                .Select(c => new StorageViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
            .ToListAsync();
        }

        public async Task HireToStorage(string userId, int storageId)
        {
            var model = await repository.GetByIdAsync<ApplicationUser>(userId);
            if (model != null)
            {
                model.StorageId = storageId;
            }

            await repository.SaveChangesAsync();
        }
    }
}
