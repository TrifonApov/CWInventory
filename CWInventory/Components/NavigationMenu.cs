using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Components
{
    public class NavigationMenu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
