using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Domain.Interfaces.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
    }
}
