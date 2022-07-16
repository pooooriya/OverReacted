using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OverReacted.Domain.Base;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Domain.Entities
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(n => n.Name).IsRequired().HasMaxLength(300);
        builder.HasMany(n => n.Users)
            .WithOne(n => n.Role)
            .HasForeignKey(n => n.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}