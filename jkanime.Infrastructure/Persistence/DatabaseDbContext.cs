using Microsoft.EntityFrameworkCore;
using jkanime.Domain.Entities;

namespace jkanime.Infrastructure.Persistence;

public class DatabaseDbContext : DbContext
{
    public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public  DbSet<Anime> Animes { get; set; }
    public DbSet<AnimeCategory> AnimeCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseDbContext).Assembly);
    }

}