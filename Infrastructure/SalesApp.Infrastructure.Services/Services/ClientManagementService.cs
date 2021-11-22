using SalesApp.Infrastructure.Data.Repositories.Interfaces;
using SalesApp.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp.Infrastructure.Services.Services
{
    public class ClientManagementService : IClientManagementService
    {
        private readonly IClientsRepository _clientsRepository;

        public ClientManagementService(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }




    }
}
