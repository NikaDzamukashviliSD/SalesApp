using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesApp.Infrastructure.Data.Entities
{
    public class Client
    {        
        [Key]
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

    }
}
