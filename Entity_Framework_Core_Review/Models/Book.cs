using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Framework_Core_Review.Models
{
    public class Book
    {
        public int BookNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }
}
