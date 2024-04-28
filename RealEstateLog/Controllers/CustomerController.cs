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

    public IActionResult Index(string? searchString, int page = 1)
    {
        var values = _context.Customers.Where(x => x.IsDeleted == false).ToList();
        ViewData["CurrentFilter"] = searchString;
        var valueSeach = from x in values select x;

        if (!string.IsNullOrEmpty(searchString))
        {
            var searchLower = searchString.ToUpper();
            valueSeach = valueSeach.Where(y => y.CustomerFullName.ToUpper().Contains(searchLower));
        }
        const int pageSize = 10;

        var model = new CustomerViewModel
        {
            PageInfo = new PageInfoModel()
            {
                TotalItems = _context.Customers.Where(x => x.IsDeleted == false).Count(),
                CurrentPage = page,
                ItemsPerPage = pageSize,
            },
            Customers = valueSeach.ToList(),
            TotalCustomers = _context.Customers.Where(x => x.IsDeleted == false).Count(),
        };
        return View(model);
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
            customer.CustomerPrice = model.CustomerPrice;
            customer.ListingNumber = model.ListingNumber;
            customer.ListingDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            customer.CustomerAddress = model.CustomerAddress;
            customer.CustomerType = model.CustomerType;
            customer.IsDeleted = false;
            customer.NextCallDate = model.NextCallDate;
            customer.FSBODate = model.FSBODate;
            customer.ListingRoomCount = model.ListingRoomCount;

        }
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult DeleteCustomer(int id)
    {
        var values = _context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
        if (values != null)
        {
            values.IsDeleted = true;
            _context.Customers.Update(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
    [HttpGet]
    public IActionResult UpdateCustomer(int id)
    {
        var values = _context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
        if (values != null)
        {
            UpdateCustomerViewModel model = new UpdateCustomerViewModel
            {
                CustomerID = id,
                CustomerAddress = values.CustomerAddress,
                CustomerDescription = values.CustomerDescription,
                CustomerFullName = values.CustomerFullName,
                CustomerPhone = values.CustomerPhone,
                CustomerPrice = values.CustomerPrice,
                CustomerType = values.CustomerType,
                FSBODate = values.FSBODate,
                ListingDate = values.ListingDate,
                ListingNumber = values.ListingNumber,
                ListingRoomCount = values.ListingRoomCount,
                NextCallDate = values.NextCallDate,
            };
            return View(model);
        }
        return View();
    }
    [HttpPost]
    public IActionResult UpdateCustomer(UpdateCustomerViewModel model)
    {
        var values = _context.Customers.Where(x => x.CustomerID == model.CustomerID).FirstOrDefault();
        if (ModelState.IsValid)
        {
            values.CustomerFullName = model.CustomerFullName;
            values.CustomerPhone = model.CustomerPhone;
            values.CustomerPrice = model.CustomerPrice;
            values.CustomerType = model.CustomerType;
            values.CustomerAddress = model.CustomerAddress;
            values.CustomerDescription = model.CustomerDescription;
            values.FSBODate = model.FSBODate;
            values.ListingDate = model.ListingDate;
            values.ListingNumber = model.ListingNumber;
            values.ListingRoomCount = model.ListingRoomCount;
            values.NextCallDate = model.NextCallDate;

            _context.Customers.Update(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}
