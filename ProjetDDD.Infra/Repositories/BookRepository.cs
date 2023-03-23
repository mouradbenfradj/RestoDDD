using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Entites;

namespace ProjetDDD.Infra.Repositories
{
    public class BookRepository : RepositoryBase<Book>,IBookRepository
    {
        
    }
}
