using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interface
{
    public interface IAdminRepository : IRepositoryBase<Admin>
    {
        bool Login(string login, string mdp);
        string GetName(int id);
        IEnumerable<Admin> GetAllAu();
        bool Remove2(Admin obj);
        Admin GetByName(string nom, string prenom);
    }
}
