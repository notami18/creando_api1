using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(creando_api.Startup))]
namespace creando_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
