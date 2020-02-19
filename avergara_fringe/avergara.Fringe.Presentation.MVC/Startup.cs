using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(avergara.Fringe.Presentation.MVC.Startup))]
namespace avergara.Fringe.Presentation.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
