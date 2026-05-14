using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using jkanime.Domain.Entities;

namespace jkanime.Infrastructure.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder){
        
        builder.ToTable("Categories");
        
        builder.Property(c=>c.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
        builder.Property(c=>c.Description).HasColumnName("description").HasMaxLength(500).IsRequired();
        builder.Property(c=>c.IsActive).HasColumnName("active").HasDefaultValue(true);
        
    }
}

