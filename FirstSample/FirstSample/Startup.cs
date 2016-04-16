using FirstChatSample;
using FirstSample.PersistentConnections;
using FirstSample.PipelineModules;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace FirstChatSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.HubPipeline.AddModule(new LoggingPipelineModule());
            GlobalHost.HubPipeline.AddModule(new ProfanityFilterPipelineModule());
            app.MapSignalR();
            app.MapSignalR<FirstPersistentConnection>("/FirstSamplePC");
        }
    }
}