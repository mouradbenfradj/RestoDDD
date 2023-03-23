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
    public class PassagerAppService : AppServiceBase<Passager, Passager_DTO>, IAppPassagerService
    {

        private readonly IPassagerService _PassagerService;
        public PassagerAppService(IPassagerService PassagerService)
            : base(PassagerService)
        {
            _PassagerService = PassagerService;
        }
        public string GetName(int id)
        {
            return _PassagerService.GetName(id);
        }

        public bool Remove2(Passager obj)
        {
            var obj_TDO = Mapper.Map<Passager, Passager_DTO>(obj);
            return _PassagerService.Remove2(obj);
        }


    }
}
