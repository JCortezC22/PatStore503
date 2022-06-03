using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatStore.Startup))]
namespace PatStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
