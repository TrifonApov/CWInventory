using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;
namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Organization that provides products")]
    public class Supplier
    {
        [Key]
        [Comment("Suplier's identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaximumLength)]
        [Comment("Suplier's name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(PhoneNumberMaximumLenght)]
        [Comment("Suplier's phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Suplier's e-mail address")]
        public string Email { get; set; } = string.Empty;
    }
}
