using CWInventory.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;
namespace CWInventory.Core.Models.Storage
{
    public class CreateStorageViewModel
    {
        [Required]
        [StringLength(NameMaximumLength,
            MinimumLength = NameMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ManagerId { get; set; } = string.Empty;
    }
}
