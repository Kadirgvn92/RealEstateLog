using Microsoft.AspNetCore.Mvc;
using RealEstateLog.Context;
using RealEstateLog.Entity;
using RealEstateLog.Models;

namespace RealEstateLog.Controllers;
public class CustomerController : Controller
{
    private readonly RealEstateLogContext _context;

    public CustomerController(RealEstateLogContext context)
    {
        _context = context;
    }

    public IActionResult Index(string? searchString)
    {
        var values = _context.Customers.ToList();
        ViewData["CurrentFilter"] = searchString;
        var valueSeach = from x in values select x;

        if (!string.IsNullOrEmpty(searchString))
        {
            var searchLower = searchString.ToUpper();
            valueSeach = valueSeach.Where(y => y.CustomerFullName.ToUpper().Contains(searchLower));
        }

        return View(valueSeach.ToList());
    }
    [HttpGet]
    public IActionResult CreateCustomer()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateCustomer(CreateCustomerViewModel model)
    {
        Customer customer = new Customer();
        {
            customer.CustomerFullName = model.CustomerFullName;
            customer.CustomerPhone = model.CustomerPhone;
            customer.CustomerDescription = model.CustomerDescription;
        }
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
