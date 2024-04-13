using static CWInventory.Infrastructure.Constants.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace CWInventory.Core.Models.Category
{
    public class CreateCategoryModel
    {
        [Required]
        [StringLength(NameMaximumLength,
            MinimumLength = NameMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
