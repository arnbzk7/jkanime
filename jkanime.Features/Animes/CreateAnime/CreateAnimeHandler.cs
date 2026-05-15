using System;
using System.Collections.Generic;
using System.Linq;
using jkanime.Domain.Entities;
using jkanime.Features.Categories.CreateCategory;
using jkanime.Features.Animes.CreateAnime;
using jkanime.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;



namespace jkanime.Features.Animes.CreateAnime;

public class CreateAnimeHandler
{
    private readonly DatabaseDbContext _dbContext;

    public CreateAnimeHandler(DatabaseDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<CreateAnimeResponse> HandleAsync(CreateAnimeRequest request)
    {
        var existing = await _dbContext.Animes.FirstOrDefaultAsync(a=>a.Name==request.Name);
        if (existing == null)
            throw new InvalidOperationException($"the anime with the name '{request.Name}' already exists");

        var anime = Anime.Create(request.Name, request.Description, request.Type, request.IsActive, request.UserId);
        _dbContext.Animes.Add(anime);
        await _dbContext.SaveChangesAsync();
        
        return new CreateAnimeResponse(anime.Id , anime.Name, anime.Description,anime.Type, anime.UserId, anime.IsActive, anime.CreatedAt);
    }
}
