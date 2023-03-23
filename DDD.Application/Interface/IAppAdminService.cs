using DDD.Application.Entites;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Interface
{
    public interface IAppAdminService : IAppServiceBase<Admin_DTO>
    {
        bool Login(string login, string mdp);
        string GetName(int id);
        
        bool Remove2(Admin obj);
        Admin_DTO GetByName(string nom, string prenom);

        
    }
}
