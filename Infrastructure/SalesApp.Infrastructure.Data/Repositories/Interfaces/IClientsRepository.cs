using SalesApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Infrastructure.Data.Repositories.Interfaces
{
    public interface IClientsRepository
    {
        Task<bool> AddClientAsync(Client client);
        Task<Client> GetClientByIdAsync(Guid clientId);
        Task<bool> RemoveClientByIdAsync(Guid clientId);
        Task<IEnumerable<Client>> GetAllClientsAsync();
    }
}
