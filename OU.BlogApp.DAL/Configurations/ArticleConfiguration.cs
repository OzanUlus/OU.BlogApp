using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(a => a.Category).WithMany(a => a.Articles)
                .HasForeignKey(a => a.CategoryId);
            builder.HasOne(a => a.Photo).WithMany(a => a.Articles)
                .HasForeignKey(a => a.PhotoId);

            builder.Property(a=>a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a=>a.Content).IsRequired();
        }
    }
}
