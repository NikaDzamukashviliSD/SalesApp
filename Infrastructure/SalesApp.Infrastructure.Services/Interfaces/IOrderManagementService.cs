using SalesApp.Infrastructure.Models.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Services.Interfaces
{
    public interface IOrderManagementService
    {
        Task<OrderViewModel> GetOrderBetweenAsync(DateTime from, DateTime to);
    }
}
