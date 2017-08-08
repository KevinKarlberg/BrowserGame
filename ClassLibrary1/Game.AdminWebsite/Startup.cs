using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Game.AdminWebsite.Startup))]
namespace Game.AdminWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
