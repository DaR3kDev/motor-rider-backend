namespace motor_rider_backend.Domain.Entities;

public class Maintenance
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? WorkshopId { get; set; }
    public string? AppointmentId { get; set; }
    public DateTime PerformedAt { get; set; }
    public string? Description { get; set; } 
    public decimal Cost { get; set; }
    public DateTime WarrantyDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Workshop? Workshop { get; set; }
    public Appointment? Appointment { get; set; }
    public ICollection<AssignedPart> AssignedParts { get; set; } = [];
}