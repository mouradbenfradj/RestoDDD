using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Domain.Interfaces.Services
{
    public interface IAuthorService : IServiceBase<Author>
    {
        string GetName(int id);
        IEnumerable<Author> GetAllAu();
        bool Remove2(Author obj);
    }
}
