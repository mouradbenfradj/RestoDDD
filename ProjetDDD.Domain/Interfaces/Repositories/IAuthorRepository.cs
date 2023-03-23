using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Domain.Interfaces.Repositories
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        string GetName(int id);
        IEnumerable<Author> GetAllAu();
        bool Remove2(Author obj);
    }
}
