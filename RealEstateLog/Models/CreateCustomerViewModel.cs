using System.ComponentModel.DataAnnotations;
#nullable disable

namespace RealEstateLog.Models;

public class CreateCustomerViewModel
{
    [Required(ErrorMessage = "Müşteri adı zorunludur.")]
    public string CustomerFullName { get; set; }
    [Required(ErrorMessage = "Müşteri telefonu zorunludur.")]
    public string CustomerPhone { get; set; }
    public string CustomerDescription { get; set; }
}
