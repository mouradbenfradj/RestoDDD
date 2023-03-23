using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using ProjetDDD.IoC.IoC;
using Microsoft.Practices.Unity;

using ProjetDDD.Application.AutoMapper;

namespace PreojtDDD.MVC
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
            IoC i = new IoC(container);
            i.ResgitreType();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //AutoMapper
            AutoMapperWebConfiguration.Configure();
        }
    }
}
