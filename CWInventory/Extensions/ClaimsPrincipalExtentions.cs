using System.Security.Claims;

namespace CWInventory.Extensions
{
    public static class ClaimsPrincipalExtentions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
