using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IRepository<User>, IDisposable
    {
        private ExchangeContext context;

        public UserRepository(ExchangeContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> Get()
        {
            return context.Users.ToList();
        }

        public User GetByID(Guid id)
        {
            return context.Users.Find(id);
        }

        public void Insert(User entity)
        {
            context.Users.Add(entity);
        }

        public void Delete(Guid id)
        {
            User User = context.Users.Find(id);
            context.Users.Remove(User);
        }

        public void Update(User entity)
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
