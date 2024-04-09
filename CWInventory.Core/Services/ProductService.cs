﻿using CWInventory.Core.Contracts;
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
                })
                .ToListAsync();
        }

        public async Task<ProductQuantityModel> GetQuantityInStorages(int productId)
        {
            var product = await repository
                .GetByIdAsync<Product>(productId);
            var productQuatities = new Dictionary<string, int>();
            var model = new ProductQuantityModel();
            
            if (product != null)
            {
                if (!product.Storages.Any())
                {
                    foreach (var storagesProducts in product.Storages)
                    {
                        var storage = await repository.GetByIdAsync<Storage>(storagesProducts.StorageId);
                        if (storage != null)
                        {
                            productQuatities.Add(storage.Name, storagesProducts.Quantity);
                        }
                    }
                }

                model.ProductId = product.Id;
                model.Name = product.Name;
                model.Description = product.Description;
                model.QuantityInStorages = productQuatities;
            };

            return model;
        }

        
    }
}
