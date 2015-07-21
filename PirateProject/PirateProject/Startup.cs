using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PirateProject.Startup))]
namespace PirateProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
