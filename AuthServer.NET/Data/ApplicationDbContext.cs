using AuthServer.NET.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.NET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAuthCode> ClientsAuthCodes { get; set; }
        public DbSet<ClientClientCredentials> ClientsClientCredentials { get; set; }
        public DbSet<ClientImplicit> ClientsImplicit { get; set; }
        public DbSet<ClientROPassword> ClientsROPassword{ get; set; }
    }
}
