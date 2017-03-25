using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen2.Startup))]
namespace Examen2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
