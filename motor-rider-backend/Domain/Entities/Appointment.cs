namespace motor_rider_backend.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? ClientId { get; set; }
    public string? WorkshopId { get; set; }
    public int? UserId { get; set; }
    public string? MotorcycleId { get; set; }
    public string? Description { get; set; }
    public DateTime DateTime { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Workshop? Workshop { get; set; } 
    public User? User { get; set; } 
    public Motorcycle? Motorcycle { get; set; } 
    public Client? Client { get; set; }
    public ICollection<Maintenance> Maintenance { get; set; } = [];
}

