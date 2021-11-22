using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Models.Enums
{
    public enum ResponseCode
    {
        [Display(Name = "Completed Successfully")]
        Success = 1,
        [Display(Name = "Unknown Error Occured")]
        UnknownError
    }

}
