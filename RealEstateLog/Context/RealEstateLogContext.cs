using Microsoft.EntityFrameworkCore;
using RealEstateLog.Entity;

namespace RealEstateLog.Context;

public class RealEstateLogContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=77.245.159.27\\MSSQLSERVER2019;database=RealEstateDb;user=RealAdmin;password=Kguven1423.");
    }
    public DbSet<Customer> Customers { get; set; }
}
