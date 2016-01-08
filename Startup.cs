using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(higherbound.org.Startup))]
namespace higherbound.org
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
