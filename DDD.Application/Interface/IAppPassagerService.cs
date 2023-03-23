using DDD.Application.Entites;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Interface
{
    public interface IAppPassagerService : IAppServiceBase<Passager_DTO>
    {
        string GetName(int id);
        
        bool Remove2(Passager obj);
    }
}
