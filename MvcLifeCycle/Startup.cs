using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLifeCycle.Startup))]
namespace MvcLifeCycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
