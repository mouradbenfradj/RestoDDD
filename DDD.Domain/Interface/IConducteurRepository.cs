using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interface
{
    public interface IConducteurRepository : IRepositoryBase<Conducteur>
    {
        string GetName(int id);
        IEnumerable<Conducteur> GetAllAu();
        bool Remove2(Conducteur obj);

    }
}
