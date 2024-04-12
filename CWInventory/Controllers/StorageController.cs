using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class StorageController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
