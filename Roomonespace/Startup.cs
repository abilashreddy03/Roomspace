using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Roomonespace.Startup))]
namespace Roomonespace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
