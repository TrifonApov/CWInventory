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

        public int? ManagerId { get; set; }
    }
}
