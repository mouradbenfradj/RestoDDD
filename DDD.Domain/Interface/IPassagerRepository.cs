using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interface
{
    public interface IPassagerRepository : IRepositoryBase<Passager>
    {
        string GetName(int id);
        IEnumerable<Passager> GetAllAu();
        bool Remove2(Passager obj);

    }
}
