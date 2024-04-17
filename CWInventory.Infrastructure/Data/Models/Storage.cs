using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Storage")]
    public class Storage
    {
        [Key]
        [Comment("Storage identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaximumLength)]
        [Comment("Storage name")]
        public string Name { get; set; } = string.Empty;

        public int? ManagerId { get; set; }
        
        [ForeignKey(nameof(ManagerId))]
        public Manager? Manager { get; set; }

        public ICollection<ApplicationUser> Employees { get; set; } = new List<ApplicationUser>();

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
