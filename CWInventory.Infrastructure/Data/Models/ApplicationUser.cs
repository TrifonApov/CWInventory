using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(
            NameMaximumLength,
            MinimumLength = NameMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(
            NameMaximumLength,
            MinimumLength = NameMinimumLength,
            ErrorMessage = LengthErrorMessage)]
        public string LastName { get; set; } = string.Empty;

        public int? StorageId { get; set; }
        
        [ForeignKey(nameof(StorageId))]
        public Storage? Storage { get; set; }

        public Manager? Manager { get; set; }

        public ICollection<Document> Documents { get; set; } = new List<Document>();

    }
}
