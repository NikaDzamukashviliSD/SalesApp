using SalesApp.Infrastructure.Common.Extensions;
using SalesApp.Infrastructure.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Models.Models.ResponseModels
{
    public class BaseResponse
    {
        public bool Success { get; set; }  // ოპერაციის წარმატების სტატუსი
        public ResponseCode ResponseCode { get; set; }  // ოპერაციის დაბრუნებული კოდი
        public string ResponseString { get { return ResponseCode.GetDisplayName(); } }  // დაბრუნებული კოდის ტექსტური დასახელება
    }
}
