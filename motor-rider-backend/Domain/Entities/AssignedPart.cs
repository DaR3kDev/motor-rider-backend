namespace motor_rider_backend.Domain.Entities;

public class AssignedPart
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? MaintenanceId { get; set; }
    public string? ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }

    // Relationships
    public Maintenance? Maintenance { get; set; } 
    public Product? Product { get; set; } 
}

