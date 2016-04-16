namespace SignalRHost.Auction
{
    public class Bid
    {
        public Bid Clone()
        {
            return (Bid)MemberwiseClone();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double BidPrice { get; set; }
        public int TimeLeft { get; set; }
        public string ConnectionId { get; set; }
    }
}