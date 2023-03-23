using DDD.Application.Entites;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Interface
{
    public interface IAppAffectationService : IAppServiceBase<Affectation_DTO>
    {
        IEnumerable<Affectation_DTO> GetAll();
    }
}
