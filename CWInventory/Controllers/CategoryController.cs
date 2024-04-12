using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllAsync()
        {
            var model = await categoryService.AllAsync();

            return View(model);
        }

        public async Task<IActionResult> GetAllProductsByCategory(int id)
        {
            var model = await categoryService.GetAllProductsByCategory(id);
            
            return View(model);
        }
    }
}
