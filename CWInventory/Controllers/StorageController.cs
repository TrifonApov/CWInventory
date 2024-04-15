using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Storage;
using Microsoft.AspNetCore.Mvc;
using static CWInventory.Core.Constants.RoleConstants;


namespace CWInventory.Controllers
{
    public class StorageController : BaseController
    {
        private IStorageService storageService;

        public StorageController(IStorageService _storageService)
        {
            storageService = _storageService;
        }

        public async Task<IActionResult> All()
        {
            var model = await storageService.AllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateAsync()
        {
            var model = new CreateStorageViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateStorageViewModel model)
        {
            if (!User.IsInRole(AdminRole))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (model != null)
            {
                await storageService.CreateAsync(model);
            }

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {
            var model = await storageService.DetailsAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(StorageDetailsViewModel model)
        {
            await storageService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await storageService.DetailsAsync(id);

            return View(model);
        }
    }
}
