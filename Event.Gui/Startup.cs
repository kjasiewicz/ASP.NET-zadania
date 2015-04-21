using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Event.Gui.Startup))]
namespace Event.Gui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
