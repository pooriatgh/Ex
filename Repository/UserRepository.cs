using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private ExchangeContext context;

        public UserRepository(ExchangeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Tbl_user> GetUsers()
        {
            return context.Users.ToList();
        }

        public Tbl_user GetUserByID(int id)
        {
            return context.Users.Find(id);
        }

        public void InsertUser(Tbl_user User)
        {
            context.Users.Add(User);
        }

        public void DeleteUser(int UserID)
        {
            Tbl_user User = context.Users.Find(UserID);
            context.Users.Remove(User);
        }

        public void UpdateUser(Tbl_user User)
        {
            context.Entry(User).State = EntityState.Modified;
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
