using DDD.Domain.Entities;
using DDD.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.Repositories
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
       
        public bool Login(string login, string mdp)
        {
            Object[] SqlParams =
            {
                new SqlParameter(@login,login),
                new SqlParameter(@mdp,mdp),
            };
            var res =
            Db.Database.SqlQuery<bool>("Sp_Account_Login @login,@mdp", SqlParams).SingleOrDefault();
            return res;
        }
        public string GetName(int id)
        {
            return Db.Set<Admin>().Find(id).nom;
        }
        public IEnumerable<Admin> GetAllAu()
        {
            return Db.Set<Admin>().ToList();
        }

        public Admin GetByName(string nom,string prenom)
    {
        return Db.Set<Admin>().Where(r => r.nom == nom && r.prenom == prenom ).Single();
    }
        public bool Remove2(Admin obj)
        {
            Db.Set<Admin>().Remove(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
