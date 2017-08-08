using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Game.Website.Startup))]
namespace Game.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
