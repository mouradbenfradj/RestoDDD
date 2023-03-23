using AutoMapper;
using DDD.Application.Entites;
using DDD.Application.Interface;
using DDD.Domain.Entities;
using DDD.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Service
{
    public class AffectationAppService : AppServiceBase<Affectation, Affectation_DTO>, IAppAffectationService
    {

        private readonly IAffectationService _AffectationService;
        public AffectationAppService(IAffectationService AffectationService)
            : base(AffectationService)
        {
            _AffectationService = AffectationService;
        }
        public IEnumerable<Affectation_DTO> GetAll()
        {
            var list = Mapper.Map<IEnumerable<Affectation>, IEnumerable<Affectation_DTO>>(_AffectationService.GetAffectationLibre());
            return list;
        }

    }
}
