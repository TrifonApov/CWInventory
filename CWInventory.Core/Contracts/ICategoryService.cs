using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Product;

namespace CWInventory.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> AllAsync();

        Task<IEnumerable<ProductModel>> GetAllProductsByCategory(int categoryId);

        Task<int> CreateAsync(CategoryModel category);

        Task EditAsync(int categoryId);
    }
}
