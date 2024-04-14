using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(NameMaximumLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(NameMaximumLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
