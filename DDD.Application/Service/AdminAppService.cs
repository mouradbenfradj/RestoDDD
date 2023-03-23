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
    public class AdminAppService : AppServiceBase<Admin, Admin_DTO>, IAppAdminService
    {

        private readonly IAdminService _AdminService;
        public AdminAppService(IAdminService AdminService)
            : base(AdminService)
        {
            _AdminService = AdminService;
        }

        public bool Login(string login, string mdp)
        {
            return _AdminService.Login(login, mdp);
        }
        public string GetName(int id)
        {
            return _AdminService.GetName(id);
        }

        public bool Remove2(Admin obj)
        {
            var obj_TDO = Mapper.Map<Admin, Admin_DTO>(obj);
            return _AdminService.Remove2(obj);
        }

        public Admin_DTO GetByName(string nom, string prenom)
        {
            var entityAdapter = Mapper.Map<Admin, Admin_DTO>(_AdminService.GetByName(nom,prenom));
            return entityAdapter;
            

        }


       

    }
}
