using Entity_Framework_Core_Review.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core_Review.Configration
{
    public class BlogEntityTypeConfigration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Url).IsRequired().HasMaxLength(200);
            builder.Ignore(b => b.addedOn);
            builder.Property(b => b.addedOn).HasColumnName("AddedOn");
            builder.Property( b => b.Url).HasColumnType("varchar(200)");
            builder.Property(b => b.Url).HasMaxLength(300);
            builder.Property(b => b.Url).HasComment("This is url of the blog");
        

        }
    }

}
