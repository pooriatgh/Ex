using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WalletRepository : IRepository<Wallet>, IDisposable
    {
        private ExchangeContext context;

        public WalletRepository(ExchangeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Wallet> Get()
        {
            return context.Wallets.ToList();
        }

        public Wallet GetByID(Guid id)
        {
            return context.Wallets.Find(id);
        }

        public void Insert(Wallet entity)
        {
            context.Wallets.Add(entity);
        }

        public void Delete(Guid id)
        {
            Wallet Wallet = context.Wallets.Find(id);
            context.Wallets.Remove(Wallet);
        }

        public void Update(Wallet entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
