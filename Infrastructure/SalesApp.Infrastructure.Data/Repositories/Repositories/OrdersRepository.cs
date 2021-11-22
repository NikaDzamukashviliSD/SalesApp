using Microsoft.EntityFrameworkCore;
using SalesApp.Infrastructure.Data.Entities;
using SalesApp.Infrastructure.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Data.Repositories.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly SalesAppDbContext _dbContext;

        public OrdersRepository(SalesAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddOrderAsync(Order order)
        {
            await _dbContext.Set<Order>().AddAsync(order);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }
        
        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            Order order = await _dbContext.Set<Order>().FindAsync(orderId);
            return order;
        }

        public async Task<bool> DeleteOrderByIdAsync(Guid orderId)
        {
            Order order = await _dbContext.Set<Order>().FindAsync(orderId);
            _dbContext.Set<Order>().Remove(order);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }

        public async Task<IEnumerable<Order>> GetSubOrdersAsync(Guid orderId)
        {
            Order order = await _dbContext.Set<Order>().FindAsync(orderId);
            if (order == null) return null;
            if (order.OrderParentId != null) return null;
            IEnumerable<Order> subOrders = await Task.FromResult(_dbContext.Set<Order>().Where(o => (o.OrderParentId == orderId)));
            return subOrders;
        }

        public async Task<Order> GetOrderBetweenAsync(DateTime from, DateTime to)
        {
            Order order = await _dbContext.Set<Order>()
                .Where(o => (o.OrderDate >= from && o.OrderDate <= to))
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefaultAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return _dbContext.Set<Order>();
        }
    }
}
