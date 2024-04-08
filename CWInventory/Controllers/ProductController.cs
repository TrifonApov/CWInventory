using CWInventory.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class ProductController : BaseController
    {
        public async Task<IActionResult> All()
        {
            var model = new AllProductsViewModel();
            return View(model);
        }
    }
}
