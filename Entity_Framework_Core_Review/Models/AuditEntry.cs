using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core_Review.Models
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
    }
}
