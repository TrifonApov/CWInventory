using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Document")]
    public class Document
    {
        [Key]
        [Comment("Document identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Document type")]
        public DocumentType Type { get; set; } = null!;

        [Comment("Creator identifier")]
        public string CreatorId { get; set; } = string.Empty;

        [Required]
        [Comment("Creator of the document")]
        [ForeignKey(nameof(CreatorId))]
        public ApplicationUser Creator { get; set; } = null!;

        [Required]
        [Comment("Client identifier")]
        public string ClientId { get; set; } = string.Empty;
        
        [ForeignKey(nameof(ClientId))]
        public ApplicationUser Client { get; set; } = null!;

        [Required]
        [Comment("Storage identifier")]
        public int StorageId { get; set; }

        [ForeignKey(nameof(StorageId))]
        public Storage Storage { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
