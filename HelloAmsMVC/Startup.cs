using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAmsMVC.Startup))]
namespace HelloAmsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
