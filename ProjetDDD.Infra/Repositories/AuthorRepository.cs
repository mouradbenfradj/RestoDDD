using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Infra.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>,IAuthorRepository
    {
        public string GetName(int id)
        {
            return Db.Set<Author>().Find(id).Forenames;
        }
        public IEnumerable<Author> GetAllAu()
        {
            return Db.Set<Author>().ToList();
        }
        public bool Remove2(Author obj)
        {
            Db.Set<Author>().Remove(obj);
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
