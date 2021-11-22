using Microsoft.EntityFrameworkCore;
using SalesApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp.Infrastructure.Data
{
    public class SalesAppDbContext : DbContext
    {
        public SalesAppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        
        public DbSet<Seller> Sellers { get; set; }
        
        public DbSet<Order> Orders { get; set; }


    }
}
