using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;
using ProjetDDD.Domain.Interfaces.Services;
using ProjetDDD.Application.Entites;


namespace ProjetDDD.Application.Interfaces
{
    public interface IAuthorAppService : IAppServiceBase<Author_DTO>
    {
        string GetName(int id);
        bool Remove2(Author obj);
    }
}
