namespace jkanime.Domain.Entities;

public class User
{
    public Guid Id { set; private get; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
}
