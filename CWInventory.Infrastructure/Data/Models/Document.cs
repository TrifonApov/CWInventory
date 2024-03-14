using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [Comment("Creator of the document")]
        public IdentityUser Creator { get; set; } = null!;
    }
}
