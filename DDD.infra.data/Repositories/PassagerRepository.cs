using DDD.Domain.Entities;
using DDD.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.Repositories
{
    public class PassagerRepository : RepositoryBase<Passager>, IPassagerRepository
    {
        public string GetName(int id)
        {
            return Db.Set<Passager>().Find(id).nom;
        }
        public IEnumerable<Passager> GetAllAu()
        {
            return Db.Set<Passager>().ToList();
        }
        public bool Remove2(Passager obj)
        {
            Db.Set<Passager>().Remove(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
