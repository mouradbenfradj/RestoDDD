using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;
using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Interfaces.Services;

namespace ProjetDDD.Domain.Services
{
    public class AuthorService : ServiceBase<Author>,IAuthorService
    {
        private readonly IAuthorRepository _AuthorRepository;
        public AuthorService(IAuthorRepository AuthorRepository)
            :base(AuthorRepository)
        {
            _AuthorRepository = AuthorRepository;
        }
        public string GetName(int id)
        {
            return _AuthorRepository.GetName(id);
        }
        public IEnumerable<Author> GetAllAu()
        {
            return _AuthorRepository.GetAllAu();
        }
        public bool Remove2(Author obj)
        {
            return _AuthorRepository.Remove2(obj);
        }
    }
}
