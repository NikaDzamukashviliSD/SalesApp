using SalesApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Data.Repositories.Interfaces
{
    public interface ISellersRepository
    {
        Task<bool> AddSellerAsync(Seller seller);
        Task<Seller> GetSellerByIdAsync(Guid sellerId);
        Task<bool> RemoveSellerById(Guid sellerId);
        Task<IEnumerable<Seller>> GetDirectEmployees(Guid sellerId);
        Task<IEnumerable<Seller>> GetAllSellersAsync();
    }
}
