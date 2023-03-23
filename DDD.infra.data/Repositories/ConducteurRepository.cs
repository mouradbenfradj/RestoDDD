using DDD.Domain.Entities;
using DDD.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.Repositories
{
    public class ConducteurRepository : RepositoryBase<Conducteur>, IConducteurRepository
    {
        public string GetName(int id)
        {
            return Db.Set<Conducteur>().Find(id).nom;
        }

       
        public IEnumerable<Conducteur> GetAllAu()
        {
            return Db.Set<Conducteur>().ToList();
        }
        public bool Remove2(Conducteur obj)
        {
            Db.Set<Conducteur>().Remove(obj);
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
