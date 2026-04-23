using Microsoft.EntityFrameworkCore;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    // =========================
    // USERS & CLIENTS
    // =========================
    public DbSet<User> Users => Set<User>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();

    // =========================
    // LOCATION
    // =========================
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Municipality> Municipalities => Set<Municipality>();
    public DbSet<Branch> Branches => Set<Branch>();

    // =========================
    // WORKSHOP
    // =========================
    public DbSet<Workshop> Workshops => Set<Workshop>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Maintenance> Maintenances => Set<Maintenance>();

    // =========================
    // MOTORCYCLE
    // =========================
    public DbSet<Motorcycle> Motorcycles => Set<Motorcycle>();
    public DbSet<EngineType> EngineTypes => Set<EngineType>();
    public DbSet<EngineSizeType> EngineSizeTypes => Set<EngineSizeType>();

    // =========================
    // INVENTORY
    // =========================
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<Movement> Movements => Set<Movement>();
    public DbSet<AssignedPart> AssignedParts => Set<AssignedPart>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

