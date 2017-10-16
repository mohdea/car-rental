using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarSystem.Startup))]
namespace CarSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
