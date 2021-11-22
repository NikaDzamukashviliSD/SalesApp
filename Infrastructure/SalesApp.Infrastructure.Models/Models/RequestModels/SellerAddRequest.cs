using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesApp.Infrastructure.Models.Models.RequestModels
{
    public class SellerAddRequest
    {
        public Guid? SellerBossId { get; set; }
        [Required]
        public string SellerFname { get; set; }
        [Required]
        public string SellerLname { get; set; }
    }
}
