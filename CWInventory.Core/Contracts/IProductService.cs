using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Product;

namespace CWInventory.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> AllProducts();

        Task<ProductQuantityModel> GetQuantityInStoragesAsync(int productId);

        Task<int> CreateAsync(CreateProductModel model);

        Task<IEnumerable<CategoryModel>> GetCategories();
        
        Task<ProductDetailsModel> DetailsAsync(int id);
    }
}
