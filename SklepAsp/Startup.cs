using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SklepAsp.Startup))]
namespace SklepAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
