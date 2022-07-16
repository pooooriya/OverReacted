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
    public class Article : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public int EstimationReadTime { get; set; }
        public Guid UserId { get; set; }
        public User Author { get; set; }
    }
}
public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.Property(n => n.Title).IsRequired().HasMaxLength(300);
        builder.Property(n => n.ShortDescription).IsRequired().HasMaxLength(300);
        builder.Property(n => n.Body).IsRequired();
        builder.Property(n => n.EstimationReadTime).IsRequired();
        builder.HasOne(n => n.Author)
            .WithMany(n => n.Articles)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}