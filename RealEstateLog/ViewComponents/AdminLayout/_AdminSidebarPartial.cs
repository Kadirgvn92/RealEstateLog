using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.ViewComponents.AdminLayout;

public class _AdminSidebarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {

        return View();

    }
}
