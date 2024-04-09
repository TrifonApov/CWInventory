namespace CWInventory.Core.Models.Product
{
    public class ProductQuantityModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;

        public Dictionary<string, int> QuantityInStorages { get; set; } = new Dictionary<string, int>();
    }
}
