using DDD.Application.AutoMapper;
using ProjetDDD.IoC.IoC;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetDDD.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ID
            IUnityContainer container = new UnityContainer();
            ProjetDDD.IoC.IoC.IoC i = new ProjetDDD.IoC.IoC.IoC(container);
            i.ResgitreType();
            DependencyResolver.SetResolver(new ProjetDDD.IoC.IoC.UnityDependencyResolver(container));

            //AutoMapper
            AutoMapperWebConfiguration.Configure();
        }
    }
}
