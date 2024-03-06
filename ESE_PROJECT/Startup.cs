using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESE_PROJECT.Startup))]
namespace ESE_PROJECT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
