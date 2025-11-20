
using AspRazor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspRazor.Data;

public class ApplicationDbContext : IdentityDbContext<Agent>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<VacationPackage> VacationPackages { get; set; } = null!;
    public DbSet<Booking> Bookings { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<VacationPackage>().HasData(
            new VacationPackage
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Price = 10.5m,
                DurationInDays = 10
            }
        );
    }
}
