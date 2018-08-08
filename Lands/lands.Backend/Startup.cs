using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lands.Backend.Startup))]
namespace lands.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
