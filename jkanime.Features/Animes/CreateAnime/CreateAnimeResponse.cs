using jkanime.Domain.Enums;

namespace jkanime.Features.Animes.CreateAnime;

public record CreateAnimeResponse(Guid Id, string Name, string? Description, AnimeType Type, Guid? UserId, bool IsActive, DateTime CreatedAt);