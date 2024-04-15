using CWInventory.Core.Models.Home;
using CWInventory.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static CWInventory.Core.Constants.RoleConstants;

namespace CWInventory.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            //if (User?.Identity != null && User.IsInRole(AdminRole))
            //{
            //    return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            //}

            if (User?.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("All", "Product");
            }

            var model = new IndexViewModel();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
