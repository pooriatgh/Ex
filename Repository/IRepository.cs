using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<Entity> : IDisposable
    {
        IEnumerable<Entity> Get();
        Entity GetByID(Guid id);
        void Insert(Entity entity);
        void Delete(Guid id);
        void Update(Entity entity);
        void Save();
    }
}
