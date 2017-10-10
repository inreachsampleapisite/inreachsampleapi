using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inreachsampleapi.Startup))]
namespace inreachsampleapi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
