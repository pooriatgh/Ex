using Domain;
using System.Data.Entity;

namespace Repository
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("ExchangeConnectionString") { }
        public DbSet<Tbl_user> Users
        {
            get;
            set;
        }
    }
}