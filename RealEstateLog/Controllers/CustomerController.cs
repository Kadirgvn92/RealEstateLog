using Microsoft.AspNetCore.Mvc;

namespace RealEstateLog.Controllers;
public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
