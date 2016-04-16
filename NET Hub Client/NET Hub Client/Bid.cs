namespace NET_Hub_Client
{
    public class Bid
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double BidPrice { get; set; }
        public int TimeLeft { get; set; }
        public string ConnectionId { get; set; }
    }
}