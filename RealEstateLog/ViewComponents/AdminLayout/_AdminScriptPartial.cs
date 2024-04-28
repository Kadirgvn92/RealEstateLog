using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.ViewComponents.AdminLayout;

public class _AdminScriptPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
