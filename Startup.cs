using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(CasaVueStatic.Startup))]
[assembly: OwinStartupAttribute(typeof(CasaVueStatic.Startup))]
namespace CasaVueStatic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
