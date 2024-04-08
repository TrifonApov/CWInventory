using CWInventory.Core.Contracts;
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
                .Select(p=> new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Price = p.Price,
                })
                .ToListAsync();
        }
    }
}
