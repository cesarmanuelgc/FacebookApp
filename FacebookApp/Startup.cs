using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookApp.Startup))]
namespace FacebookApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
