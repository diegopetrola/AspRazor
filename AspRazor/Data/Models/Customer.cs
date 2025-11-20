
namespace AspRazor.Data.Models;

public class Customer
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public Agent? Agent { get; set; }
    public string? AgentId { get; set; }
    public ICollection<Booking> Bookings { get; set; } = [];
}