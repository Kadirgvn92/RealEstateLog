﻿using System.ComponentModel.DataAnnotations;

namespace RealEstateLog.Models;

public class CreateCustomerViewModel
{
    [Required(ErrorMessage = "Müşteri adı zorunludur.")]
    public string CustomerFullName { get; set; }
    [Required(ErrorMessage = "Müşteri telefonu zorunludur.")]
    public string CustomerPhone { get; set; }
    public string? ListingNumber { get; set; }
    public string? CustomerType { get; set; }
    public string? CustomerAddress { get; set; }
    public string? ListingRoomCount { get; set; }
    public double? CustomerPrice { get; set; }
    public DateTime? ListingDate { get; set; }
    public DateTime? FSBODate { get; set; }
    public DateTime? NextCallDate { get; set; }
    public string? CustomerDescription { get; set; }
    public bool IsDeleted { get; set; }
}
