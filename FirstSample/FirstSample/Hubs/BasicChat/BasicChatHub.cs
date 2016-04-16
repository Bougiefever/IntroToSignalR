using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace FirstSample.Hubs.BasicChat
{
    [HubName("chat")]
    public class BasicChatHub : Hub
    {
        public void BroadcastMessage(Message message)
        {
            Clients.Caller.displayText("me", message.Text);
            Clients.Others.displayText(message.Name, message.Text);
        }
    }
}