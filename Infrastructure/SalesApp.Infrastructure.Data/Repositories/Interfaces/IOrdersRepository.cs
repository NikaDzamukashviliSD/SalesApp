using SalesApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Data.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        Task<bool> AddOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(Guid orderId);
        Task<bool> DeleteOrderByIdAsync(Guid orderId);
        Task<IEnumerable<Order>> GetSubOrdersAsync(Guid orderId);
        Task<Order> GetOrderBetweenAsync(DateTime from, DateTime to);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}
