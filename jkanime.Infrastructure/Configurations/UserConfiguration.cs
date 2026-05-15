using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using jkanime.Domain.Entities;

namespace jkanime.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder) 
    {
        builder.ToTable("Users");
        builder.HasKey(u => u.Id);
        builder.Property(u=>u.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
        builder.Property(u=>u.Description).HasColumnName("description").HasMaxLength(100).IsRequired();
        builder.Property(u=>u.IsActive).HasColumnName("Active").HasDefaultValue(true);
        
    }
    
}