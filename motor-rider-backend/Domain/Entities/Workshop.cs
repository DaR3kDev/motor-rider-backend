namespace motor_rider_backend.Domain.Entities;

public class Workshop
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? BranchId { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Branch? Branch { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = [];
    public ICollection<Maintenance> Maintenance { get; set; } = [];
}

