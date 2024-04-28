using Microsoft.EntityFrameworkCore;
using RealEstateLog.Entity;

namespace RealEstateLog.Context;

public class RealEstateLogContext : DbContext
{
    public RealEstateLogContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Customer> Customers { get; set; }
}
