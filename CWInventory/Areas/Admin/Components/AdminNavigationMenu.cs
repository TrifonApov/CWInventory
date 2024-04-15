using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Areas.Admin.Components
{
    public class AdminNavigationMenu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
