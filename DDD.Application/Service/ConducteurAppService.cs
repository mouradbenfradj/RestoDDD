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
    public class ConducteurAppService : AppServiceBase<Conducteur, Conducteur_DTO>, IAppConducteurService
    {

        private readonly IConducteurService _ConducteurService;
        public ConducteurAppService(IConducteurService ConducteurService)
            : base(ConducteurService)
        {
            _ConducteurService = ConducteurService;
        }
        public string GetName(int id)
        {
            return _ConducteurService.GetName(id);
        }

        public bool Remove2(Conducteur obj)
        {
            var obj_TDO = Mapper.Map<Conducteur, Conducteur_DTO>(obj);
            return _ConducteurService.Remove2(obj);
        }


    }
}
