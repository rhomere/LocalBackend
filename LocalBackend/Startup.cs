using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LocalBackend.Startup))]

namespace LocalBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}