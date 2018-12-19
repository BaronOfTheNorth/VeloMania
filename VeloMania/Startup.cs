using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeloMania.Startup))]
namespace VeloMania
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
