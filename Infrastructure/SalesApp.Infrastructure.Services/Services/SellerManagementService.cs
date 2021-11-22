using SalesApp.Infrastructure.Data.Repositories.Interfaces;
using SalesApp.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp.Infrastructure.Services.Services
{
    public class SellerManagementService : ISellerManagementService
    {
        private readonly ISellersRepository _sellersRepository;

        public SellerManagementService(ISellersRepository sellersRepository)
        {
            _sellersRepository = sellersRepository;
        }

    }
}
