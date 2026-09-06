using Entity_Framework_Core_Review.Configration;
using Entity_Framework_Core_Review.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core_Review
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFcore;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>(); // Domain class for AuditEntry
            modelBuilder.ApplyConfiguration(new BlogEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new PostEntityTableConfigration());
            modelBuilder.ApplyConfiguration(new BookEntityTypeConfigration());
            //modelBuilder.Entity<Blog>().ToTable("Blogs", b => b.ExcludeFromMigrations());
            modelBuilder.HasDefaultSchema("Blogging"); // default schema for all tables in the model

            modelBuilder.Entity<Post>().ToView("SelectPosts" , schema: "Blogging"); // map Post entity to a view named SelectPosts in the Blogging schema

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Book> Books { get; set; }


    }
}
