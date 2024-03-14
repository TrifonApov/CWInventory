using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static CWInventory.Infrastructure.Constants.DataConstants;

namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Document type")]
    public class DocumentType
    {
        [Key]
        [Comment("Document type identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaximumLength)]
        [Comment("Document type name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaximumLength)]
        [Comment("Document type description")]
        public string Description { get; set; } = string.Empty;

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
