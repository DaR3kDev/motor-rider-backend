namespace motor_rider_backend.Domain.Entities;

public class Motorcycle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? EngineTypeId { get; set; }
    public string? EngineSizeTypeId { get; set; }
    public string? UserId { get; set; }
    public string? SerialNumber { get; set; } 
    public string? PlateNumber { get; set; } 
    public string? Brand { get; set; } 
    public string? Model { get; set; } 
    public int CubicCentimeters { get; set; }
    public string? Color { get; set; } 

    // Relationships
    public User? User { get; set; }
    public EngineType? EngineType { get; set; }
    public EngineSizeType? EngineSizeType { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = [];
}

