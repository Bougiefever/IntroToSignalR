using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRClient.Startup))]
namespace SignalRClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
