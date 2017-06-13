using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DroneLander.Service.Startup))]

namespace DroneLander.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}