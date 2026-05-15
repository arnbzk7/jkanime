using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using jkanime.Domain.Entities;

namespace jkanime.Infrastructure.Configurations;

public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
{
    public void Configure(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable("Animes");
        builder.HasKey(c=>c.Id);
        builder.Property(a=>a.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
        builder.Property(a=>a.Description).HasColumnName("description").HasMaxLength(500).IsRequired();
        builder.Property(a=>a.IsActive).HasColumnName("active").HasDefaultValue(true).IsRequired();
        
    }
}