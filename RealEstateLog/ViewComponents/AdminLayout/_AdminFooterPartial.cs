using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.ViewComponents.AdminLayout;

public class _AdminFooterPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
