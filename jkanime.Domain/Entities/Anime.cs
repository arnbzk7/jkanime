using jkanime.Domain.Enums;

namespace jkanime.Domain.Entities;

public class Anime
{
    public Guid Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }
    public AnimeType Type { get; private set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public Guid? UserId { get; set; }
    public User? User { get; set; }
    
    public static Anime Create(string name, string? description, AnimeType type, bool isActive, Guid? userId = null)
    {
        return new Anime
        {
            Name = name,
            Description = description,
            Type = type,
            UserId = userId,
            IsActive = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null
        };
    }
}
