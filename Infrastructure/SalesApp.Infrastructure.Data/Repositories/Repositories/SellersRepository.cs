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
    public class SellersRepository : ISellersRepository
    {
        private readonly SalesAppDbContext _dbContext;

        public SellersRepository(SalesAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task<bool> containsCycle(Guid sellerId, Guid? bossId)
        {
            return false;
        }

        public async Task<bool> AddSellerAsync(Seller seller)
        {
            if (await containsCycle(seller.SellerId, seller.SellerBossId))
                return false;
            await _dbContext.Set<Seller>().AddAsync(seller);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }

        public async Task<Seller> GetSellerByIdAsync(Guid sellerId)
        {
            Seller seller = await _dbContext.Set<Seller>().FindAsync(sellerId);
            return seller;
        }

        public async Task<bool> RemoveSellerById(Guid sellerId)
        {
            Seller seller = await _dbContext.Set<Seller>().FindAsync(sellerId);
            _dbContext.Set<Seller>().Remove(seller);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }

        public async Task<IEnumerable<Seller>> GetDirectEmployees(Guid sellerId)
        {
            if (!await _dbContext.Set<Seller>().AnyAsync(s => (s.SellerId == sellerId))) return null;
            IEnumerable<Seller> employees =
                await Task.FromResult(_dbContext.Set<Seller>().Where(s => (s.SellerBossId == sellerId && s.SellerId != sellerId)));
            return employees;
        }

        public async Task<IEnumerable<Seller>> GetAllSellersAsync()
        {
            return _dbContext.Set<Seller>();
        }
    }
}
