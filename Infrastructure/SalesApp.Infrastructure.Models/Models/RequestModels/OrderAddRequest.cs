using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesApp.Infrastructure.Models.Models.RequestModels
{
    public class OrderAddRequest
    {
        [Required]
        public Guid OrderClientId { get; set; }
        [Required]
        public Guid OrderSellerId { get; set; }
        [Required]
        public double OrderAmmount { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public IEnumerable<OrderAddRequest> SubOrders { get; set; }

    }
}
