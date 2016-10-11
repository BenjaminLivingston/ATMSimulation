using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATMSimulation.Startup))]
namespace ATMSimulation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
