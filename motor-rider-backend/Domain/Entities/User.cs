using motor_rider_backend.Domain.Enums.Common;
using motor_rider_backend.Domain.Enums.Users;

namespace motor_rider_backend.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? DocumentTypeId { get; set; }
    public string? MunicipalityId { get; set; }
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public string? Email { get; set; } 
    public string? Password { get; set; } 
    public string? DocumentNumber { get; set; }
    public Gender Gender { get; set; }
    public Status Status { get; set; } = Status.ACTIVE;
    public Role Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }

    // Relationships
    public DocumentType? DocumentType { get; set; } 
    public Municipality? Municipality { get; set; } 
    public ICollection<Appointment> Appointments { get; set; } = [];
    public ICollection<Motorcycle> Motorcycles { get; set; } = [];
}