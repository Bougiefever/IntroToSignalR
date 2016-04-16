using System;
using System.Collections.Generic;

namespace FirstSample.Hubs.Auction
{
    public static class BidManager
    {
        static System.Threading.Timer _timer = new System.Threading.Timer(BidInterval, null, 0, 2000);
        public static Bid CurrentBid { get; set; }
        public static void Start()
        {
            
        }
        static void BidInterval(object o)
        {
            var clients = Microsoft.AspNet.SignalR.GlobalHost.ConnectionManager.GetHubContext<AuctionHub>().Clients;
            if (BidManager.CurrentBid == null || BidManager.CurrentBid.TimeLeft <= 0)
            {
                BidManager.SetBid();
            }
            BidManager.CurrentBid.TimeLeft -= 2;
            if (BidManager.CurrentBid.TimeLeft <= 0)
            {
                clients.AllExcept(CurrentBid.ConnectionId).CloseBid();
                if (!string.IsNullOrWhiteSpace(CurrentBid.ConnectionId))
                    clients.Client(CurrentBid.ConnectionId).CloseBidWin(CurrentBid);
            }
            clients.All.UpdateBid(BidManager.CurrentBid);
        }
        static List<Bid> _items = new List<Bid>(){
            new Bid(){Name="Bike", Description="10 Speed", TimeLeft = 30, BidPrice = 120.0},
            new Bid(){Name="Car", Description="Sports Car", TimeLeft = 30, BidPrice = 1500.0},
            new Bid(){Name="TV", Description="Big screen TV", TimeLeft = 30, BidPrice = 330.0},
            new Bid(){Name="Boat", Description="Party Boat", TimeLeft = 30, BidPrice = 1200.0},
            new Bid() {Name="Camper", Description="22' Camper",TimeLeft=30, BidPrice = 3000.0}
        };
        public static void SetBid()
        {
            Random rnd = new Random();
            CurrentBid = (Bid)_items[rnd.Next(0, _items.Count - 1)].Clone();
        }
    }
}