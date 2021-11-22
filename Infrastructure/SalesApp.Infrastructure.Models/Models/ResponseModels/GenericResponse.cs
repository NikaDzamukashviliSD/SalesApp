using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Models.Models.ResponseModels
{
    public class GenericResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
