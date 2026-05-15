using jkanime.Domain.Enums;

namespace jkanime.Features.Animes.CreateAnime;

public record CreateAnimeRequest(string Name, string Description,bool IsActive, AnimeType Type, Guid? UserId = null);