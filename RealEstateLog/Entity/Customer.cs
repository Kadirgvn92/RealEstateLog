using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RealEstateLog.Entity;

public class Customer
{
    public int CustomerID { get; set; }
    [Required(ErrorMessage = "Müşteri adı zorunludur.")]
    public string  CustomerFullName { get; set; }
    [Required(ErrorMessage = "Müşteri telefonu zorunludur.")]
    public string CustomerPhone { get; set; }
    public string CustomerDescription { get; set; }
}
