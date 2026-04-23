using motor_rider_backend.Domain.Enums.Common;

namespace motor_rider_backend.Domain.Entities;

public class Municipality
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? DepartmentId { get; set; }
    public string? Name { get; set; } 
    public Status Status { get; set; } = Status.ACTIVE;

    // Relationships
    public Department? Department { get; set; }
    public ICollection<User> Users { get; set; } = [];
    public ICollection<Branch> Branches { get; set; } = [];
}