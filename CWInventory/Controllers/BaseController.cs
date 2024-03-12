using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
