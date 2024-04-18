using CWInventory.Core.Models.Document;

namespace CWInventory.Core.Contracts
{
    public interface IDocumentService
    {
        Task<IEnumerable<DocimentViewModel>> AllAsync();
    }
}
