using Microsoft.Owin;
using Njinx.Service.Services;
using Owin;

[assembly: OwinStartupAttribute(typeof(Njinx.App.Startup))]
namespace Njinx.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configService = new ConfigService();
            ConfigureAuth(configService, app);
            configService.ConfigureAutomapper();
        }
    }
}
