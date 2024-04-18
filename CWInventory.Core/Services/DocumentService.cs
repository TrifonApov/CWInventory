using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Document;
using CWInventory.Infrastructure.Data.Common;

namespace CWInventory.Core.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository repository;

        public DocumentService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task<IEnumerable<DocimentViewModel>> AllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
