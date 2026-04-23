namespace motor_rider_backend.Domain.Entities;

public class Client
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? DocumentTypeId { get; set; }
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public string? DocumentNumber { get; set; }
    public string? Phone { get; set; } 
    public string? Email { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public DocumentType? DocumentType { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = [];
}
