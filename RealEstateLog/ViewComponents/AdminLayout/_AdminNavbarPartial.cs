using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.ViewComponents.AdminLayout;

public class _AdminNavbarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
