using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;
using ProjetDDD.Domain.Interfaces.Services;
using ProjetDDD.Application.Interfaces;

using ProjetDDD.Application.Entites;
using AutoMapper;

namespace ProjetDDD.Application.Services
{
    public class AuthorAppService : AppServiceBase<Author, Author_DTO>, IAuthorAppService
    {
        
        private readonly IAuthorService _AuthorService;
        public AuthorAppService(IAuthorService AuthorService)
            :base(AuthorService)
        {
            _AuthorService = AuthorService;
        }
        public string GetName(int id)
        {
            return _AuthorService.GetName(id);
        }

        public bool Remove2(Author obj)
        {
            var obj_TDO = Mapper.Map<Author, Author_DTO>(obj);
            return _AuthorService.Remove2(obj);
        }


    }
}
