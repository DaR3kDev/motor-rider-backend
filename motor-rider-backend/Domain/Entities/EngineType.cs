namespace motor_rider_backend.Domain.Entities;

public class EngineType
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    
    // Relationships
    public ICollection<Motorcycle> Motorcycles { get; set; } = [];
}

