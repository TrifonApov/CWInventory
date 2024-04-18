using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Product;
using CWInventory.Infrastructure.Data.Common;
using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CWInventory.Core.Services
{
    public class ProductService : IProductService
    {
        private IRepository repository;
        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<ProductModel>> AllProducts()
        {
            return await repository
                .AllReadOnly<Product>()
                .Select(p => new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Storages = p.Storages
                })
                .ToListAsync();
        }

        public async Task<ProductQuantityModel> GetQuantityInStoragesAsync(int productId)
        {
            var model = new ProductQuantityModel();

            var product = repository
                .AllReadOnly<Product>()
                .Select(p => new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Storages = p.Storages
                }).FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                model.ProductId = product.Id;
                model.Name = product.Name;
                model.Description = product.Description;


                if (product.Storages.Any())
                {
                    foreach (var storagesProducts in product.Storages)
                    {
                        var storage = await repository.GetByIdAsync<Storage>(storagesProducts.StorageId);
                        if (storage != null)
                        {
                            model.QuantityInStorages.Add(storage.Name, storagesProducts.Quantity);
                        }
                    }
                }


            };

            return model;
        }

        public async Task<IEnumerable<CategoryModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => new CategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<int> CreateAsync(CreateProductModel model)
        {
            var product = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;
        }

        public async Task<IEnumerable<CategoryModel>> GetCategories()
        {
            return await repository
                .AllReadOnly<Category>()
                .Select(c => new CategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
            .ToListAsync();
        }

        public Task<ProductDetailsModel> DetailsAsync(int id)
        {
            return repository
                .AllReadOnly<Product>()
                .Select(p => new ProductDetailsModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Price = p.Price.ToString()
                })
                .FirstAsync(p => p.Id == id);
        }

        public Task<EditProductModel> EditDetaisAsync(int id)
        {
            var model = repository
                .AllReadOnly<Product>()
                .Where(p => p.Id == id)
                .Select(p => new EditProductModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    CategoryId = p.Category.Id,
                    Description = p.Description,
                    Price = p.Price
                })
                .FirstOrDefaultAsync(p => p.Id == id);


            return model;
        }

        public async Task EditAsync(EditProductModel model)
        {
            var product = await repository.GetByIdAsync<Product>(model.Id);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.Price = model.Price;
                product.ImageUrl = model.ImageUrl;
                product.CategoryId = model.CategoryId;
            }
        }
    }
}
