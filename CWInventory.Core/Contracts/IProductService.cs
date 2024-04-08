using CWInventory.Core.Models.Product;

namespace CWInventory.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> AllProducts();
    }
}
