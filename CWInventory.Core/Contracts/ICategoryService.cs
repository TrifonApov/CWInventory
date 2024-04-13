using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Product;

namespace CWInventory.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> AllAsync();

        Task<IEnumerable<ProductModel>> GetAllProductsByCategory(int categoryId);

        public Task<CategoryModel> Details(int id);

        Task<int> CreateAsync(CategoryModel category);

        Task<CategoryModel> EditAsync(CategoryModel model);
    }
}
