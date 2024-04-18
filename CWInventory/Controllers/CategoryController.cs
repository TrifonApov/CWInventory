using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Category;
using CWInventory.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class CategoryController : BaseController
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

        public async Task<IActionResult> All()
        {
            var model = await categoryService.AllAsync();

            return View(model);
        }

        public async Task<IActionResult> GetAllProductsByCategory(int id)
        {
            var model = await categoryService.GetAllProductsByCategory(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateAsync()
        {
            var model = new CreateCategoryModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    await categoryService.CreateAsync(model);
                }
            }

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {
            var model = await categoryService.Details(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(CategoryModel model)
        {
            await categoryService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }
    }
}
