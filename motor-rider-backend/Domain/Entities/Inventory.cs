using motor_rider_backend.Domain.Enums.Inventory;

namespace motor_rider_backend.Domain.Entities;

public class Inventory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? ProductId { get; set; }
    public string? BranchId { get; set; }
    public int Quantity { get; set; }
    public InventoryStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Product? Product { get; set; }
    public Branch? Branch { get; set; }
    public ICollection<Movement> Movements { get; set; } = [];
}

