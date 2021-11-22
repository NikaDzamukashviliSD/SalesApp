using Microsoft.EntityFrameworkCore;
using SalesApp.Infrastructure.Data.Entities;
using SalesApp.Infrastructure.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Data.Repositories.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly SalesAppDbContext _dbContext;

        public ClientsRepository(SalesAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddClientAsync(Client client)
        {
            await _dbContext.Set<Client>().AddAsync(client);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return _dbContext.Set<Client>();
        }

        public async Task<Client> GetClientByIdAsync(Guid clientId)
        {
            Client client = await _dbContext.Set<Client>().FindAsync(clientId);
            return client;
        }

        public async Task<bool> RemoveClientByIdAsync(Guid clientId)
        {
            Client client = await _dbContext.Set<Client>().FindAsync(clientId);
            _dbContext.Set<Client>().Remove(client);
            var changes = await _dbContext.SaveChangesAsync();
            return (changes > 0);
        }
    }
}
