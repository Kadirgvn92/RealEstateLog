using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.ViewComponents.AdminLayout;

public class _AdminHeaderPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
