using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sitaad.Startup))]
namespace Sitaad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
