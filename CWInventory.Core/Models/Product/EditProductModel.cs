using CWInventory.Core.Models.Category;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Core.Models.Product
{
    public class EditProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaximumLength,
            MinimumLength = NameMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DescriptionMaximumLength,
            MinimumLength = DescriptionMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryModel> Categories { get; set; } = new List<CategoryModel>();
    }
}
