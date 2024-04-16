using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Storage;
using CWInventory.Infrastructure.Data.Common;
using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CWInventory.Core.Services
{
    public class StorageService : IStorageService
    {
        private readonly IRepository repository;

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

        public async Task EditAsync(StorageDetailsViewModel model)
        {
            var storage = await repository.GetByIdAsync<Storage>(model.Id);

            if (storage != null)
            {
                storage.Name = model.Name;
                storage.ManagerId = model.ManagerId;
            }

            await repository.SaveChangesAsync();
        }
        
        public async Task<StorageDetailsViewModel> DetailsAsync(int id)
        {
            var storage = await repository
                .AllReadOnly<Storage>()
                .Where(s => s.Id == id)
                .Include(s=> s.Manager)
                .FirstAsync();

            return new StorageDetailsViewModel()
            {
                Id = storage.Id,
                Name = storage.Name,
                ManagerId = storage.ManagerId,
                Manager = $"{storage.Manager.FirstName} {storage.Manager.LastName}",
                Employees = storage.Employees.Select(e => $"{e.FirstName} {e.LastName}").ToList(),
                Products = storage.Products.Select(p => $"{p.Name} - {p.Storages.Where(sp => sp.StorageId == storage.Id).Select(sp => sp.Quantity)}").ToList()
            };
        }

    }
}
