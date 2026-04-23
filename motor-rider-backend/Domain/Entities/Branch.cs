namespace motor_rider_backend.Domain.Entities;

public class Branch
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? MunicipalityId { get; set; }
    public string? Name { get; set; } 
    public string? Phone { get; set; } 
    public string? Address { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Municipality? Municipality { get; set; } 
    public ICollection<Workshop> Workshops { get; set; } = [];
    public ICollection<Inventory> Inventory { get; set; } = [];
}

