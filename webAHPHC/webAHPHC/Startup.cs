using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webAHPHC.Startup))]
namespace webAHPHC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
