namespace NET_Hub_Client
{
    partial class AuctionClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentBid = new System.Windows.Forms.Button();
            this.MakeBid = new System.Windows.Forms.Button();
            this.Bid = new System.Windows.Forms.TextBox();
            this.Wins = new System.Windows.Forms.ListBox();
            this.Name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.BidDisplay = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentBid
            // 
            this.CurrentBid.Location = new System.Drawing.Point(12, 114);
            this.CurrentBid.Name = "CurrentBid";
            this.CurrentBid.Size = new System.Drawing.Size(75, 23);
            this.CurrentBid.TabIndex = 0;
            this.CurrentBid.Text = "Current Bid";
            this.CurrentBid.UseVisualStyleBackColor = true;
            this.CurrentBid.Click += new System.EventHandler(this.CurrentBid_Click);
            // 
            // MakeBid
            // 
            this.MakeBid.Location = new System.Drawing.Point(93, 114);
            this.MakeBid.Name = "MakeBid";
            this.MakeBid.Size = new System.Drawing.Size(75, 23);
            this.MakeBid.TabIndex = 1;
            this.MakeBid.Text = "Make Bid";
            this.MakeBid.UseVisualStyleBackColor = true;
            this.MakeBid.Click += new System.EventHandler(this.MakeBid_Click);
            // 
            // Bid
            // 
            this.Bid.Location = new System.Drawing.Point(174, 116);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(100, 20);
            this.Bid.TabIndex = 2;
            // 
            // Wins
            // 
            this.Wins.FormattingEnabled = true;
            this.Wins.Location = new System.Drawing.Point(12, 149);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(264, 82);
            this.Wins.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(20, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(69, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "NameDisplay";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(20, 73);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(94, 13);
            this.Description.TabIndex = 5;
            this.Description.Text = "DescriptionDisplay";
            // 
            // BidDisplay
            // 
            this.BidDisplay.AutoSize = true;
            this.BidDisplay.Location = new System.Drawing.Point(211, 22);
            this.BidDisplay.Name = "BidDisplay";
            this.BidDisplay.Size = new System.Drawing.Size(22, 13);
            this.BidDisplay.TabIndex = 6;
            this.BidDisplay.Text = "Bid";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(211, 73);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(64, 13);
            this.Time.TabIndex = 7;
            this.Time.Text = "TimeDisplay";
            // 
            // AuctionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.BidDisplay);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.Bid);
            this.Controls.Add(this.MakeBid);
            this.Controls.Add(this.CurrentBid);
            this.Text = "Auction Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CurrentBid;
        private System.Windows.Forms.Button MakeBid;
        private System.Windows.Forms.TextBox Bid;
        private System.Windows.Forms.ListBox Wins;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label BidDisplay;
        private System.Windows.Forms.Label Time;
    }
}

