using SalesApp.Infrastructure.Data.Repositories.Interfaces;
using SalesApp.Infrastructure.Models.Models.ViewModels;
using SalesApp.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Services.Services
{
    public class OrderManagementService : IOrderManagementService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrderManagementService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<OrderViewModel> GetOrderBetweenAsync(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
