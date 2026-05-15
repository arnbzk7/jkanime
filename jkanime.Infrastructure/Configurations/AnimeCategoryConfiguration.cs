using jkanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jkanime.Infrastructure.Configurations;


public class AnimeCategoryConfiguration : IEntityTypeConfiguration<AnimeCategory>
{
    public void Configure(EntityTypeBuilder<AnimeCategory> builder)
    {
        builder.ToTable("AnimeCategories");
        builder.HasNoKey();
        
    }
}