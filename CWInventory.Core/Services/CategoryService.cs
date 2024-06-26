﻿using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Product;
using CWInventory.Infrastructure.Data.Common;
using CWInventory.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CWInventory.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository repository;

        public CategoryService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<CategoryModel>> AllAsync()
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

        public async Task<IEnumerable<ProductModel>> GetAllProductsByCategory(int categoryId)
        {
            var products = await repository
                .AllReadOnly<Product>()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category = p.Category.Name
                })
                .ToListAsync();

            return products;
        }

        public async Task<CategoryModel> Details(int id)
        {
            var category = await repository.GetByIdAsync<Category>(id);
            var model = new CategoryModel();

            if (category != null)
            { 
                model.Id = category.Id;
                model.Name = category.Name;
            }

            return model;
        }

        public async Task<int> CreateAsync(CategoryModel category)
        {
            var model = new Category()
            {
                Name = category.Name,
            };

            await repository.AddAsync(model);
            await repository.SaveChangesAsync();

            return category.Id;
        }

        public async Task<CategoryModel> EditAsync(CategoryModel model)
        {
            var category = await repository.GetByIdAsync<Category>(model.Id);

            if (category != null)
            {
                category.Name = model.Name;
                await repository.SaveChangesAsync();

                return new CategoryModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                };
            }

            return null;
        }

    }
}
