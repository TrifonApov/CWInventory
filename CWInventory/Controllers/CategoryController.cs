using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
