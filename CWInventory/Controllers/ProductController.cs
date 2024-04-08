using CWInventory.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService productService;
        
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await productService.AllProducts();
            
            return View(model);
        }
    }
}
