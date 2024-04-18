using CWInventory.Core.Models.Category;

namespace CWInventory.Core.Models.Product
{
    public class ProductDetailsModel
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public IEnumerable<CategoryModel> Categories { get; set; } = new List<CategoryModel>();
    }
}
