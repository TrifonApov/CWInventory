using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Product category")]
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaximumLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
