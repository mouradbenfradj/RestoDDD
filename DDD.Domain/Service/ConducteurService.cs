using DDD.Domain.Entities;
using DDD.Domain.Interface;
using DDD.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Service
{
    public class ConducteurService : ServiceBase<Conducteur>, IConducteurService
    {
        private readonly IConducteurRepository _ConducteurRepository;
        public ConducteurService(IConducteurRepository ConducteurRepository)
            : base(ConducteurRepository)
        {
            _ConducteurRepository = ConducteurRepository;
        }
        public string GetName(int id)
        {
            return _ConducteurRepository.GetName(id);
        }
        public IEnumerable<Conducteur> GetAllAu()
        {
            return _ConducteurRepository.GetAllAu();
        }
        public bool Remove2(Conducteur obj)
        {
            return _ConducteurRepository.Remove2(obj);
        }
    }
}
