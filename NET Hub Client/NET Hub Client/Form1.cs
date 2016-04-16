using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json.Linq;

namespace NET_Hub_Client
{
    public partial class AuctionClient : Form
    {
        private HubConnection _hubConnection;
        private IHubProxy _auctionProxy;
        delegate void UpdateBid(dynamic bid, int formObject);
        delegate void UpdateButtons(bool enabled);
        UpdateBid _updateDelegate;
        UpdateButtons _updateButtonsDelegate;
        public AuctionClient()
        {
            InitializeComponent();
            SetupHub();
        }
        private async void SetupHub()
        {
            _updateDelegate = UpdateBidMethod;
            _updateButtonsDelegate = UpdateButtonsMethod;
            _hubConnection = new HubConnection("http://localhost:45907");
            _auctionProxy = _hubConnection.CreateHubProxy("auction");
            _auctionProxy.On<Bid>("UpdateBid", bid =>
            {
                Invoke(_updateDelegate, bid, 0);
                Invoke(_updateButtonsDelegate, true);
            });
            _auctionProxy.On<Bid>("CloseBid", bid =>
            {
                Invoke(_updateButtonsDelegate, false);
            });
            _auctionProxy.On<Bid>("CloseBidWin", bid =>
            {
                Invoke(_updateButtonsDelegate, false);
                Invoke(_updateDelegate, bid, 1);
            });

            await _hubConnection.Start();
        }
        public void UpdateBidMethod(dynamic bid, int formObject)
        {
            if (bid != null)
            {
                Name.Text = bid.Name;
                Description.Text = bid.Description;
                BidDisplay.Text = bid.BidPrice.ToString();
                Time.Text = bid.TimeLeft.ToString();
                if (formObject > 0)
                {
                    Wins.Items.Add(bid.Name + " at " + bid.BidPrice);
                }
            }
        }
        void UpdateButtonsMethod(bool enabled)
        {
            CurrentBid.Enabled = enabled;
            MakeBid.Enabled = enabled;
        }

        private void CurrentBid_Click(object sender, EventArgs e)
        {
            _auctionProxy.Invoke("MakeCurrentBid");
        }

        private void MakeBid_Click(object sender, EventArgs e)
        {
            _auctionProxy.Invoke<string>("MakeBid", Bid.Text);
        }

    }
}
