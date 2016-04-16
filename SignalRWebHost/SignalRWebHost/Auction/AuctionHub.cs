using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRWebHost.Auction
{
    [HubName("auction")]
    public class AuctionHub : Hub
    {
        public AuctionHub()
        {
            BidManager.Start();
        }
        public override Task OnConnected()
        {
            Clients.Caller.CloseBid();
            Clients.All.UpdateBid(BidManager.CurrentBid);
            return base.OnConnected();
        }
        public void MakeCurrentBid()
        {
            BidManager.CurrentBid.BidPrice += 1;
            BidManager.CurrentBid.ConnectionId = this.Context.ConnectionId;
            Clients.All.UpdateBid(BidManager.CurrentBid);
        }
        public void MakeBid(double bid)
        {
            if (bid < BidManager.CurrentBid.BidPrice)
            {
                return;
            }
            BidManager.CurrentBid.BidPrice = bid;
            BidManager.CurrentBid.ConnectionId = this.Context.ConnectionId;
            Clients.All.UpdateBid(BidManager.CurrentBid);
        }


    }
}