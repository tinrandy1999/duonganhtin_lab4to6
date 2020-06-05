using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duonganhtin_lab4to6.Startup))]
namespace duonganhtin_lab4to6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
