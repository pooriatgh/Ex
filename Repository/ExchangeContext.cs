using Domain;
using Domain.Entities;
using System.Data.Entity;

namespace Repository
{
    public class ExchangeContext : DbContext
    {
        public ExchangeContext() : base("ExchangeConnectionString") { }
        public DbSet<User> Users
        {
            get;
            set;
        }
        public DbSet<Wallet> Wallets
        {
            get;
            set;
        }
    }
}