using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CampingHalconMVC.Startup))]
namespace CampingHalconMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
