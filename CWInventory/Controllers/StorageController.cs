using CWInventory.Core.Contracts;
using CWInventory.Core.Models.Category;
using CWInventory.Core.Models.Storage;
using CWInventory.Core.Services;
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
            //if (User.IsInRole(AdminRole))
            //{
            //}
            //else
            //{
            //    return BadRequest();
            //}
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
    }
}
