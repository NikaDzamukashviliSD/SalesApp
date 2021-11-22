using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesApp.Infrastructure.Data.Entities
{
    public class Seller
    {
        [Key]
        public Guid Id { get; set; }

        public Guid BossId { get; set; }
        
        /*[ForeignKey("BossId")]
        public Seller Boss { get; set; }*/
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

    }
}
