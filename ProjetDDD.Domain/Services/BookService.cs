using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Interfaces.Services;
using ProjetDDD.Domain.Entites;
using ProjetDDD.Domain.Interfaces.Repositories;

namespace ProjetDDD.Domain.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _BookRepository;
        public BookService(IBookRepository BookRepository)
            :base(BookRepository)
        {
            _BookRepository = BookRepository;
        }
    }
}
