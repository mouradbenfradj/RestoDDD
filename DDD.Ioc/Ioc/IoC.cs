using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using System.Web.Mvc;
using DDD.Domain.Interface;
using DDD.infra.data.Repositories;
using DDD.Domain.Interface.Service;
using DDD.Domain.Service;

using DDD.Application.Service;
using DDD.Application.Interface;

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
            _Container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
           
            _Container.RegisterType<IConducteurRepository, ConducteurRepository>();
            _Container.RegisterType<IPassagerRepository, PassagerRepository>();
            _Container.RegisterType<IReclamationRepository, ReclamationRepository>();
            _Container.RegisterType<IAffectationRepository, AffectationRepository>();
            _Container.RegisterType<IAdminRepository, AdminRepository>();


            _Container.RegisterType(typeof(IServiceBase<>), typeof(ServiceBase<>));
            _Container.RegisterType<IConducteurService, ConducteurService>();
            _Container.RegisterType<IPassagerService, PassagerService>();
            _Container.RegisterType<IReclamationService, ReclamationService>();
            _Container.RegisterType<IAffectationService, AffectationService>();
            _Container.RegisterType<IAdminService, AdminService>();


            
            _Container.RegisterType<IAppConducteurService, ConducteurAppService>();
            _Container.RegisterType<IAppPassagerService, PassagerAppService>();
            _Container.RegisterType<IAppReclamationService, ReclamationAppService>();
            _Container.RegisterType<IAppAffectationService, AffectationAppService>();
            _Container.RegisterType<IAppAdminService, AdminAppService>();




        }





    }
}
