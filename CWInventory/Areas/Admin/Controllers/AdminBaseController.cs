using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CWInventory.Core.Constants.RoleConstants;

namespace CWInventory.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
    }
}
