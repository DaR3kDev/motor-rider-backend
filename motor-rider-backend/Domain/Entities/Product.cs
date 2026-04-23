using motor_rider_backend.Domain.Enums.Inventory;

namespace motor_rider_backend.Domain.Entities;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; } 
    public string? Description { get; set; } 
    public decimal UnitPrice { get; set; }
    public ProductType ProductType { get; set; }
    public ProductStatus Status { get; set; }

    // Relationships
    public ICollection<Inventory> Inventory { get; set; } = [];
    public ICollection<AssignedPart> AssignedParts { get; set; } = [];
}

