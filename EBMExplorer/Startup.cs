using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EBMExplorer.Startup))]
namespace EBMExplorer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
