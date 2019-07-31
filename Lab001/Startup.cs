using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab001.Startup))]
namespace Lab001
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
