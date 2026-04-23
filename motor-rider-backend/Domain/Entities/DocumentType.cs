namespace motor_rider_backend.Domain.Entities;

public class DocumentType
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Abbreviation { get; set; }

    // Relacionships
    public ICollection<User> Users { get; set; } = [];
    public ICollection<Client> Clients { get; set; } = [];
}

