using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarpinTec.Startup))]
namespace CarpinTec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
