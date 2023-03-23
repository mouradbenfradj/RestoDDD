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
    public class AffectationService : ServiceBase<Affectation>, IAffectationService
    {
        private readonly IAffectationRepository _AffectationRepository;
        public AffectationService(IAffectationRepository AffectationRepository)
            : base(AffectationRepository)
        {
            _AffectationRepository = AffectationRepository;
        }

        public IEnumerable<Affectation> GetAffectationLibre()
        {
            return _AffectationRepository.GetAffectationLibre();
        }
    }
}
