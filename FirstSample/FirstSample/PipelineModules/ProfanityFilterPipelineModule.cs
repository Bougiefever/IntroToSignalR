using System;
using System.Diagnostics;
using System.Threading.Tasks;
using FirstSample.Hubs.BasicChat;
using Microsoft.AspNet.SignalR.Hubs;

namespace FirstSample.PipelineModules
{
    public class ProfanityFilterPipelineModule : HubPipelineModule
    {
        public override Func<IHubIncomingInvokerContext, Task<object>> BuildIncoming(Func<IHubIncomingInvokerContext, Task<object>> invoker)
        {
            Debug.Print("Build Incoming -- looking for naughty words");

            return base.BuildIncoming(context =>
            {
                if (context.MethodDescriptor.Name == "BroadcastMessage")
                {
                    var msg = ((Message)context.Args[0]).Text;

                    if (msg.Contains("naughty"))
                    {
                        Debug.Print("Naughty words were successfully vanquished.");
                        return null;
                    }
                }

                Debug.Print("I'll allow it.");
                return invoker(context);
            });
        }
    }
}