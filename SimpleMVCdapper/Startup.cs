using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleMVCdapper.Startup))]
namespace SimpleMVCdapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
