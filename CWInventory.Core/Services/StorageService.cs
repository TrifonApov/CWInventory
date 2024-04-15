using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Storage;
using CWInventory.Infrastructure.Data.Common;
using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CWInventory.Core.Services
{
    public class StorageService : IStorageService
    {
        private IRepository repository;

        public StorageService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<StorageViewModel>> AllAsync()
        {
            return await repository
                .AllReadOnly<Storage>()
                .Select(s => new StorageViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ManagerId = s.ManagerId
                })
                .ToListAsync();
        }

        public async Task CreateAsync(CreateStorageViewModel model)
        {
            var newStorage = new Storage()
            {
                Name = model.Name,
                ManagerId = model.ManagerId,
            };

            await repository.AddAsync(newStorage);
            await repository.SaveChangesAsync();
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
