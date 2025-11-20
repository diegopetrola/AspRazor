
namespace AspRazor.Data.Models;

public class VacationPackage
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required int DurationInDays { get; set; }
    public ICollection<Booking> Bookings { get; set; } = [];
}
