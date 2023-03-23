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
    public class AdminService : ServiceBase<Admin>, IAdminService
    {
        private readonly IAdminRepository _AdminRepository;
        public AdminService(IAdminRepository AdminRepository)
            : base(AdminRepository)
        {
            _AdminRepository = AdminRepository;
        }

        public bool Login(string login, string mdp)
        {
            return _AdminRepository.Login(login, mdp);
        }
        public string GetName(int id)
        {
            return _AdminRepository.GetName(id);
        }
        public IEnumerable<Admin> GetAllAu()
        {
            return _AdminRepository.GetAllAu();
        }

        public Admin GetByName(string nom, string prenom)
        {
            return _AdminRepository.GetByName(nom, prenom);
        }
    
        public bool Remove2(Admin obj)
        {
            return _AdminRepository.Remove2(obj);
        }
    }
	
	
}
