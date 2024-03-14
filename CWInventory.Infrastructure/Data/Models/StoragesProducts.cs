using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWInventory.Infrastructure.Data.Models
{
    [Comment("Products in different storeges with quantity")]
    public class StoragesProducts
    {
        [Comment("Storage identifier")]
        public int StorageId { get; set; }

        [ForeignKey(nameof(StorageId))]
        public Storage Storage { get; set; } = null!;

        [Comment("Product identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Comment("Product Quantity in given storage")]
        public int Quantity { get; set; }
    }
}