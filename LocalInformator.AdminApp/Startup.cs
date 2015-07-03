using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalInformator.AdminApp.Startup))]
namespace LocalInformator.AdminApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
