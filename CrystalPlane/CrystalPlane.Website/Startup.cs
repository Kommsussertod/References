using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalPlane.Website.Startup))]
namespace CrystalPlane.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
