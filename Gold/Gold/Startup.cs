using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gold.Startup))]
namespace Gold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
