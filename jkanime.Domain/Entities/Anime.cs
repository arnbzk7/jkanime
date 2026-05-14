namespace jkanime.Domain.Entities;

public class Anime
{
    public Guid Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public Guid? UserId { get; private set; }
    public User? User { get; private set; }
}
