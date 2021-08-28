namespace Atom_Care
{
    partial class market
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
            this.components = new System.ComponentModel.Container();
            this.lblmoney_in_market = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaRaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.market_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioactivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmoney_in_market
            // 
            this.lblmoney_in_market.AutoSize = true;
            this.lblmoney_in_market.Location = new System.Drawing.Point(724, 65);
            this.lblmoney_in_market.Name = "lblmoney_in_market";
            this.lblmoney_in_market.Size = new System.Drawing.Size(46, 17);
            this.lblmoney_in_market.TabIndex = 1;
            this.lblmoney_in_market.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.toysToolStripMenuItem,
            this.abilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 425);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photonToolStripMenuItem,
            this.electronToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.foodToolStripMenuItem.Text = "food";
            // 
            // photonToolStripMenuItem
            // 
            this.photonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsToolStripMenuItem});
            this.photonToolStripMenuItem.Name = "photonToolStripMenuItem";
            this.photonToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.photonToolStripMenuItem.Text = "photon";
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.coinsToolStripMenuItem.Text = "50 coins";
            this.coinsToolStripMenuItem.Click += new System.EventHandler(this.PhotonsToolStripMenuItem_Click);
            // 
            // electronToolStripMenuItem
            // 
            this.electronToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsToolStripMenuItem1});
            this.electronToolStripMenuItem.Name = "electronToolStripMenuItem";
            this.electronToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.electronToolStripMenuItem.Text = "electron";
            // 
            // coinsToolStripMenuItem1
            // 
            this.coinsToolStripMenuItem1.Name = "coinsToolStripMenuItem1";
            this.coinsToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.coinsToolStripMenuItem1.Text = "100 coins";
            this.coinsToolStripMenuItem1.Click += new System.EventHandler(this.ElectronsToolStripMenuItem_Click);
            // 
            // toysToolStripMenuItem
            // 
            this.toysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gammaRaysToolStripMenuItem});
            this.toysToolStripMenuItem.Name = "toysToolStripMenuItem";
            this.toysToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.toysToolStripMenuItem.Text = "toys";
            // 
            // gammaRaysToolStripMenuItem
            // 
            this.gammaRaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsToolStripMenuItem2});
            this.gammaRaysToolStripMenuItem.Name = "gammaRaysToolStripMenuItem";
            this.gammaRaysToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.gammaRaysToolStripMenuItem.Text = "gamma rays";
            // 
            // coinsToolStripMenuItem2
            // 
            this.coinsToolStripMenuItem2.Name = "coinsToolStripMenuItem2";
            this.coinsToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.coinsToolStripMenuItem2.Text = "250 coins";
            this.coinsToolStripMenuItem2.Click += new System.EventHandler(this.GammaRaysToolStripMenuItem2_Click);
            // 
            // market_timer
            // 
            this.market_timer.Enabled = true;
            this.market_timer.Tick += new System.EventHandler(this.market_timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atom_Care.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(720, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // abilitiesToolStripMenuItem
            // 
            this.abilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioactivityToolStripMenuItem});
            this.abilitiesToolStripMenuItem.Name = "abilitiesToolStripMenuItem";
            this.abilitiesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.abilitiesToolStripMenuItem.Text = "abilities";
            // 
            // radioactivityToolStripMenuItem
            // 
            this.radioactivityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsToolStripMenuItem3});
            this.radioactivityToolStripMenuItem.Name = "radioactivityToolStripMenuItem";
            this.radioactivityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radioactivityToolStripMenuItem.Text = "radioactivity";
            // 
            // coinsToolStripMenuItem3
            // 
            this.coinsToolStripMenuItem3.Name = "coinsToolStripMenuItem3";
            this.coinsToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.coinsToolStripMenuItem3.Text = "500 coins";
            this.coinsToolStripMenuItem3.Click += new System.EventHandler(this.RadioactivityToolStripMenuItem_Click);
            // 
            // market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atom_Care.Properties.Resources.shop_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblmoney_in_market);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "market";
            this.Text = "market";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmoney_in_market;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaRaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem2;
        private System.Windows.Forms.Timer market_timer;
        private System.Windows.Forms.ToolStripMenuItem abilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioactivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem3;
    }
}