﻿namespace CWInventory.Core.Models.Storage
{
    public class StorageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ManagerId { get; set; }
    }
}
