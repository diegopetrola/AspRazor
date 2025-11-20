
using Microsoft.AspNetCore.Identity;

namespace AspRazor.Data.Models;

public class Agent : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Navigation Properties
    public ICollection<Customer> Customers { get; set; } = [];
}
