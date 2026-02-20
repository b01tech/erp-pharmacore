namespace Pharmacore.Core.Base;

public abstract class Entity
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }
    public DateTime? DeletedAt { get; private set; }

    protected Entity() { }

    public override bool Equals(object? obj) => obj is Entity entity && entity.Id == Id;

    public override int GetHashCode() => Id.GetHashCode();
}
