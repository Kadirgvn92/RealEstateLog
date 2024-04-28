using Microsoft.EntityFrameworkCore;
using RealEstateLog.Entity;

namespace RealEstateLog.Context;

public class RealEstateLogContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=DESKTOP-A6C5CRN\\MSSQLSERVER01;database=RealEstateLogDb;Trusted_Connection=True;TrustServerCertificate=true");
    }
    public DbSet<Customer> Customers { get; set; }
}
