using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Denovo.Web.Startup))]
namespace Denovo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
