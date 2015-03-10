using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zajecia03_wf.Startup))]
namespace Zajecia03_wf
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
