using RealEstateLog.Entity;

namespace RealEstateLog.Models;
#nullable disable

public class CustomerViewModel
{
    public int CustomerID { get; set; }
    public string CustomerFullName { get; set; }
    public string CustomerPhone { get; set; }
    public string ListingNumber { get; set; }
    public string CustomerType { get; set; }
    public string CustomerAddress { get; set; }
    public string ListingRoomCount { get; set; }
    public double CustomerPrice { get; set; }
    public DateTime ListingDate { get; set; }
    public DateTime FSBODate { get; set; }
    public DateTime NextCallDate { get; set; }
    public string CustomerDescription { get; set; }
    public bool IsDeleted { get; set; }
    public int TotalCustomers { get; set; }
    public PageInfoModel PageInfo { get; set; }
    public List<Customer> Customers { get; set; }

}
