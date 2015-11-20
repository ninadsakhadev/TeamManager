using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamManager.IdSrv.Startup))]
namespace TeamManager.IdSrv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
