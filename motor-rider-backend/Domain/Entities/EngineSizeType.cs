namespace motor_rider_backend.Domain.Entities;

public class EngineSizeType
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Capacity { get; set; } 

    // Relationships
    public ICollection<Motorcycle> Motorcycles { get; set; } = [];
}

