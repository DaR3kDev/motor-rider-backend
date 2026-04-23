
namespace motor_rider_backend.Domain.Entities;

public class Department
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }

    // Relationships
    public ICollection<Municipality> Municipalities { get; set; } = [];
}

