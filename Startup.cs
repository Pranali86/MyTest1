using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudmvc.Startup))]
namespace crudmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
