using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nomina2018.Startup))]
namespace Nomina2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            //ConfigureAuth(app);
        }
    }
}
