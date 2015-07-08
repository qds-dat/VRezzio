using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VRezzio.Startup))]
namespace VRezzio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
