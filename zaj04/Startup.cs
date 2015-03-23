using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zaj04.Startup))]
namespace zaj04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
