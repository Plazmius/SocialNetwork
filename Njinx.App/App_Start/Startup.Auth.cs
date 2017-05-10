using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Njinx.Core.Entities;
using Njinx.Service.Services;
using Njinx.Service.Services.IdentityServices;

namespace Njinx.App
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(ConfigService service, IAppBuilder app)
        {
            service.ConfigureAuth(app);
        }
    }
}