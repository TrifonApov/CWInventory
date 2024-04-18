using CWInventory.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        public async Task<IActionResult> All()
        {
            var model = await userService.AllAsync();
            
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> HireToStorage(string id)
        {
            var model = await userService.UserDetails(id);
            
            if (model == null)
            {
                return BadRequest();
            }

            model.Storages = await userService.GetStorages();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> HireToStorage(string userId, int storageId)
        {
            var storages = await userService.GetStorages();
            if (!storages.Any(s => s.Id == storageId))
            {
                return BadRequest();
            }

            await userService.HireToStorage(userId, storageId);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> SetAsStorageManager(string id)
        {
            await userService.SetAsStorageManager(id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveManager(string id)
        {
            await userService.RemoveManager(id);

            return RedirectToAction(nameof(All));
        }
    }
}
