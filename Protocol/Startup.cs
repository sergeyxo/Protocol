using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Protocol.Startup))]
namespace Protocol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
