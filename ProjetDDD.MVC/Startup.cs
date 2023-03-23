using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetDDD.MVC.Startup))]
namespace ProjetDDD.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
