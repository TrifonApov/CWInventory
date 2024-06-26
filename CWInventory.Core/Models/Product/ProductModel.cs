﻿using CWInventory.Infrastructure.Data.Models;

namespace CWInventory.Core.Models.Product
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public ICollection<StoragesProducts> Storages { get; set; } = new List<StoragesProducts>();
    }
}
