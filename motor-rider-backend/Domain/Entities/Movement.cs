using motor_rider_backend.Domain.Enums.Inventory;

namespace motor_rider_backend.Domain.Entities;

public class Movement
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? InventoryId { get; set; }
    public MovementType MovementType { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;

    // Relationships
    public Inventory? Inventory { get; set; } 
}

