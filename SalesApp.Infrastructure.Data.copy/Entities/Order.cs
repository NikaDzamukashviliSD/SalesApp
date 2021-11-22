using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesApp.Infrastructure.Data.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ParentId { get; set; }

        /*[ForeignKey("ParentId")]
        public Order Parent { get; set; }*/

        public Guid ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public Guid SellerId { get; set; }

        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }

        public double Ammount { get; set; }

        public DateTime Date { get; set; }

    }
}
