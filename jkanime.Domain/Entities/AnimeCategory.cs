namespace jkanime.Domain.Entities;

public class AnimeCategory
{

    public Guid AnimeId { get; set; }
    public Anime? Anime { get; private set; }

    public Guid CategoryId { get; private set; }
    public Category? Category { get; private set; }
}
