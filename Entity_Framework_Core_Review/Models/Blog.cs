using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framework_Core_Review.Models
{
  
    public class Blog
    {
        public int Id { get; set; }
        [Comment("This is the url of the blog")]
        [MaxLength(300)]
        [Column(TypeName ="varchar(200)")]
        //[Column("BlogUrl")] // Data Annotation to specify the column name in the database
        public string Url { get; set; }
        //[NotMapped] // Data Annotation to indicate that this property should not be mapped to a database column
       
        public DateTime addedOn { get; set; }
        public List<Post> Posts { get; set; }
    }
}
