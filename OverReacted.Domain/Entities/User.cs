using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OverReacted.Domain.Base;
using OverReacted.Domain.Entities;

namespace OverReacted.Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsEmailActive { get; set; }
        public DateTimeOffset? LastVerificationSent { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public virtual List<Article> Articles { get; set; }
    }
}

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(n => n.Id).IsUnique();
        builder.Property(c => c.Id).HasDefaultValueSql("uuid_generate_v4()");
        builder.HasIndex(n => n.Email).IsUnique();
        builder.Property(n => n.Email).IsRequired().HasMaxLength(300);
        builder.Property(n => n.Name).IsRequired().HasMaxLength(100);
        builder.Property(n => n.VerifyCode).HasMaxLength(1000);
        builder.HasOne(n => n.Role)
            .WithMany(n => n.Users)
            .HasForeignKey(n => n.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}