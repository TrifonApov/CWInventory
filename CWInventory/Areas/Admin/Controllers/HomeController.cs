using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
