using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWInventory.Infrastructure.Data.Models
{
    public class Manager
    {
        [Key]
        [Comment("Manager identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("Manager's storage identifier")]
        public int StorageId { get; set; }

        [ForeignKey(nameof(StorageId))]
        public Storage Storage { get; set; } = null!;
    }
}
