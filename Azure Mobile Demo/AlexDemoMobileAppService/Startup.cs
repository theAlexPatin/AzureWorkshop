using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AlexDemoMobileAppService.Startup))]

namespace AlexDemoMobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}