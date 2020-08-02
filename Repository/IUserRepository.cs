using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<Tbl_user> GetUsers();
        Tbl_user GetUserByID(int userId);
        void InsertUser(Tbl_user user);
        void DeleteUser(int userID);
        void UpdateUser(Tbl_user user);
        void Save();
    }
}
