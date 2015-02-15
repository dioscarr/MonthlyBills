using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monthlybills.Startup))]
namespace Monthlybills
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
