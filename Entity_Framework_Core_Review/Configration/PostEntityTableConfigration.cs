using Entity_Framework_Core_Review.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core_Review.Configration
{
    public class PostEntityTableConfigration : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts" , schema:"Blogging");
        }
    }
}
