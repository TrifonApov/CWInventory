using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Product;
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
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.AllProducts();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ProductQuantityAsync(int id)
        {
            var model = await productService.GetQuantityInStoragesAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {
            var model = new CreateProductModel();
            model.Categories = await productService.GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateProductModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    await productService.CreateAsync(model);
                }
            }
            else
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await productService.DetailsAsync(id);

            return View(model);
        }

    }
}
