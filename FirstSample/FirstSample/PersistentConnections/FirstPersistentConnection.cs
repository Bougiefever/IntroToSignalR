using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace FirstSample.PersistentConnections
{
    public class FirstPersistentConnection :PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }
}