using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Domain.Interfaces.Services
{
    public interface IBookService : IRepositoryBase<Book>
    {
    }
}
