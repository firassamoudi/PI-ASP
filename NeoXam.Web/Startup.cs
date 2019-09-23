using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeoXam.Web.Startup))]
namespace NeoXam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
