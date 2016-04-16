using System.Diagnostics;
using Microsoft.AspNet.SignalR.Hubs;

namespace FirstSample.PipelineModules
{
    public class LoggingPipelineModule : HubPipelineModule
    {

        protected override bool OnBeforeOutgoing(IHubOutgoingInvokerContext context)
        {
            Debug.Print(context.Invocation.Hub + "." + context.Invocation.Method + " was called successfully");
            
            return base.OnBeforeOutgoing(context);
        }

        protected override bool OnBeforeIncoming(IHubIncomingInvokerContext context)
        {
            Debug.Print(context.MethodDescriptor.Hub.Name + "." + context.MethodDescriptor.Name + " call was received");
            return base.OnBeforeIncoming(context);
        }

    }
}