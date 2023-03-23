using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using System.Web.Mvc;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Domain.Interfaces.Services;

using ProjetDDD.Infra.Repositories;
using ProjetDDD.Domain.Services;
using ProjetDDD.Application.Services;
using ProjetDDD.Application.Interfaces;

namespace ProjetDDD.IoC.IoC
{
    public class IoC
    {
        private static IUnityContainer _Container;

        public IoC(IUnityContainer Container)
        {
            _Container = Container;
        }
        public void ResgitreType()
        {
            _Container.RegisterType(typeof (IRepositoryBase<>),typeof (RepositoryBase<>));
            _Container.RegisterType<IBookRepository, BookRepository>();
            _Container.RegisterType<IAuthorRepository, AuthorRepository>();

            _Container.RegisterType<IAuthorAppService, AuthorAppService>();
            _Container.RegisterType<IAuthorService, AuthorService>();
            _Container.RegisterType<IBookService, BookService>();



        }
    }
}
