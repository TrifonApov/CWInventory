using CWInventory.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class DocumentController : BaseController
    {
        private readonly IDocumentService documentService;

        public DocumentController(IDocumentService _documentService)
        {
            IDocumentService documentService = _documentService;
        }

        public async Task<IActionResult> AllAsync()
        {
            var model = await documentService.AllAsync();

            return View(model);
        }
    }
}
