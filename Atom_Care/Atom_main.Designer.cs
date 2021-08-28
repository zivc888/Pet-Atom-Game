namespace Atom_Care
{
    partial class Atom_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_main));
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.lblenergy = new System.Windows.Forms.Label();
            this.lblhappiness = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.time_is_money = new System.Windows.Forms.Timer(this.components);
            this.lblmarket = new System.Windows.Forms.Label();
            this.happy_timer = new System.Windows.Forms.Timer(this.components);
            this.picgamma_ray = new System.Windows.Forms.PictureBox();
            this.picphoton = new System.Windows.Forms.PictureBox();
            this.picelectron = new System.Windows.Forms.PictureBox();
            this.picmarket = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnsettings = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.picatom = new System.Windows.Forms.PictureBox();
            this.picenergy = new System.Windows.Forms.PictureBox();
            this.lblgamma_ray = new System.Windows.Forms.Label();
            this.lblphoton = new System.Windows.Forms.Label();
            this.lblelectrons = new System.Windows.Forms.Label();
            this.gamma_cooldown = new System.Windows.Forms.Timer(this.components);
            this.energy_timer = new System.Windows.Forms.Timer(this.components);
            this.lbllevel = new System.Windows.Forms.Label();
            this.face_cooldown = new System.Windows.Forms.Timer(this.components);
            this.lblxp = new System.Windows.Forms.Label();
            this.radioactive_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picgamma_ray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picphoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picelectron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picenergy)).BeginInit();
            this.SuspendLayout();
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // lblenergy
            // 
            this.lblenergy.AutoSize = true;
            this.lblenergy.Location = new System.Drawing.Point(68, 410);
            this.lblenergy.Name = "lblenergy";
            this.lblenergy.Size = new System.Drawing.Size(46, 17);
            this.lblenergy.TabIndex = 4;
            this.lblenergy.Text = "label1";
            // 
            // lblhappiness
            // 
            this.lblhappiness.AutoSize = true;
            this.lblhappiness.Location = new System.Drawing.Point(68, 354);
            this.lblhappiness.Name = "lblhappiness";
            this.lblhappiness.Size = new System.Drawing.Size(46, 17);
            this.lblhappiness.TabIndex = 8;
            this.lblhappiness.Text = "label1";
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Location = new System.Drawing.Point(724, 65);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblmoney.Size = new System.Drawing.Size(46, 17);
            this.lblmoney.TabIndex = 12;
            this.lblmoney.Text = "label1";
            this.lblmoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_is_money
            // 
            this.time_is_money.Enabled = true;
            this.time_is_money.Interval = 20000;
            this.time_is_money.Tick += new System.EventHandler(this.time_is_money_Tick);
            // 
            // lblmarket
            // 
            this.lblmarket.AutoSize = true;
            this.lblmarket.Location = new System.Drawing.Point(719, 193);
            this.lblmarket.Name = "lblmarket";
            this.lblmarket.Size = new System.Drawing.Size(51, 17);
            this.lblmarket.TabIndex = 14;
            this.lblmarket.Text = "market";
            // 
            // happy_timer
            // 
            this.happy_timer.Enabled = true;
            this.happy_timer.Interval = 5000;
            this.happy_timer.Tick += new System.EventHandler(this.happy_timer_Tick);
            // 
            // picgamma_ray
            // 
            this.picgamma_ray.Image = global::Atom_Care.Properties.Resources.gamma_ray;
            this.picgamma_ray.Location = new System.Drawing.Point(213, 12);
            this.picgamma_ray.Name = "picgamma_ray";
            this.picgamma_ray.Size = new System.Drawing.Size(50, 50);
            this.picgamma_ray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picgamma_ray.TabIndex = 17;
            this.picgamma_ray.TabStop = false;
            this.picgamma_ray.Click += new System.EventHandler(this.picgamma_ray_Click);
            // 
            // picphoton
            // 
            this.picphoton.Image = ((System.Drawing.Image)(resources.GetObject("picphoton.Image")));
            this.picphoton.Location = new System.Drawing.Point(305, 12);
            this.picphoton.Name = "picphoton";
            this.picphoton.Size = new System.Drawing.Size(50, 50);
            this.picphoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picphoton.TabIndex = 16;
            this.picphoton.TabStop = false;
            this.picphoton.Click += new System.EventHandler(this.picphoton_Click);
            // 
            // picelectron
            // 
            this.picelectron.Image = global::Atom_Care.Properties.Resources.electron;
            this.picelectron.Location = new System.Drawing.Point(396, 12);
            this.picelectron.Name = "picelectron";
            this.picelectron.Size = new System.Drawing.Size(50, 50);
            this.picelectron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picelectron.TabIndex = 15;
            this.picelectron.TabStop = false;
            this.picelectron.Click += new System.EventHandler(this.picelectron_Click);
            // 
            // picmarket
            // 
            this.picmarket.Image = global::Atom_Care.Properties.Resources.shop;
            this.picmarket.Location = new System.Drawing.Point(720, 140);
            this.picmarket.Name = "picmarket";
            this.picmarket.Size = new System.Drawing.Size(50, 50);
            this.picmarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmarket.TabIndex = 13;
            this.picmarket.TabStop = false;
            this.picmarket.Click += new System.EventHandler(this.picmarket_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Atom_Care.Properties.Resources.coin;
            this.pictureBox3.Location = new System.Drawing.Point(720, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btnsettings
            // 
            this.btnsettings.Image = global::Atom_Care.Properties.Resources.settings;
            this.btnsettings.Location = new System.Drawing.Point(12, 12);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(50, 50);
            this.btnsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsettings.TabIndex = 10;
            this.btnsettings.TabStop = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Atom_Care.Properties.Resources.happy;
            this.pictureBox2.Location = new System.Drawing.Point(12, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Image = global::Atom_Care.Properties.Resources.exit;
            this.btnexit.Location = new System.Drawing.Point(720, 391);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(50, 50);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 3;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // picatom
            // 
            this.picatom.BackColor = System.Drawing.Color.Transparent;
            this.picatom.Image = global::Atom_Care.Properties.Resources.atom_eyes4;
            this.picatom.Location = new System.Drawing.Point(225, 100);
            this.picatom.Name = "picatom";
            this.picatom.Size = new System.Drawing.Size(256, 256);
            this.picatom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picatom.TabIndex = 0;
            this.picatom.TabStop = false;
            this.picatom.Click += new System.EventHandler(this.picatom_Click);
            // 
            // picenergy
            // 
            this.picenergy.Image = global::Atom_Care.Properties.Resources.energy;
            this.picenergy.Location = new System.Drawing.Point(12, 391);
            this.picenergy.Name = "picenergy";
            this.picenergy.Size = new System.Drawing.Size(50, 50);
            this.picenergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picenergy.TabIndex = 2;
            this.picenergy.TabStop = false;
            // 
            // lblgamma_ray
            // 
            this.lblgamma_ray.AutoSize = true;
            this.lblgamma_ray.Location = new System.Drawing.Point(198, 65);
            this.lblgamma_ray.Name = "lblgamma_ray";
            this.lblgamma_ray.Size = new System.Drawing.Size(80, 17);
            this.lblgamma_ray.TabIndex = 18;
            this.lblgamma_ray.Text = "unavailable";
            // 
            // lblphoton
            // 
            this.lblphoton.AutoSize = true;
            this.lblphoton.Location = new System.Drawing.Point(293, 65);
            this.lblphoton.Name = "lblphoton";
            this.lblphoton.Size = new System.Drawing.Size(75, 17);
            this.lblphoton.TabIndex = 19;
            this.lblphoton.Text = "photons: 0";
            // 
            // lblelectrons
            // 
            this.lblelectrons.AutoSize = true;
            this.lblelectrons.Location = new System.Drawing.Point(384, 65);
            this.lblelectrons.Name = "lblelectrons";
            this.lblelectrons.Size = new System.Drawing.Size(82, 17);
            this.lblelectrons.TabIndex = 20;
            this.lblelectrons.Text = "electrons: 0";
            // 
            // gamma_cooldown
            // 
            this.gamma_cooldown.Interval = 1000;
            this.gamma_cooldown.Tick += new System.EventHandler(this.gamma_cooldown_Tick);
            // 
            // energy_timer
            // 
            this.energy_timer.Enabled = true;
            this.energy_timer.Interval = 1000;
            this.energy_timer.Tick += new System.EventHandler(this.energy_timer_Tick);
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbllevel.Location = new System.Drawing.Point(12, 238);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(74, 25);
            this.lbllevel.TabIndex = 21;
            this.lbllevel.Text = "level: 0";
            // 
            // face_cooldown
            // 
            this.face_cooldown.Interval = 1000;
            this.face_cooldown.Tick += new System.EventHandler(this.face_cooldown_Tick);
            // 
            // lblxp
            // 
            this.lblxp.AutoSize = true;
            this.lblxp.Location = new System.Drawing.Point(16, 221);
            this.lblxp.Name = "lblxp";
            this.lblxp.Size = new System.Drawing.Size(50, 17);
            this.lblxp.TabIndex = 22;
            this.lblxp.Text = "xp / tot";
            // 
            // radioactive_timer
            // 
            this.radioactive_timer.Interval = 1000;
            this.radioactive_timer.Tick += new System.EventHandler(this.radioactive_timer_Tick);
            // 
            // Atom_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblxp);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.lblelectrons);
            this.Controls.Add(this.lblphoton);
            this.Controls.Add(this.lblgamma_ray);
            this.Controls.Add(this.picgamma_ray);
            this.Controls.Add(this.picphoton);
            this.Controls.Add(this.picelectron);
            this.Controls.Add(this.lblmarket);
            this.Controls.Add(this.picmarket);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.lblhappiness);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblenergy);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.picatom);
            this.Controls.Add(this.picenergy);
            this.Name = "Atom_main";
            this.Text = "Atom_main";
            ((System.ComponentModel.ISupportInitialize)(this.picgamma_ray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picphoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picelectron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picenergy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picenergy;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Label lblenergy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblhappiness;
        private System.Windows.Forms.PictureBox btnsettings;
        private System.Windows.Forms.PictureBox picatom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Timer time_is_money;
        private System.Windows.Forms.PictureBox picmarket;
        private System.Windows.Forms.Label lblmarket;
        private System.Windows.Forms.Timer happy_timer;
        private System.Windows.Forms.PictureBox picelectron;
        private System.Windows.Forms.PictureBox picphoton;
        private System.Windows.Forms.PictureBox picgamma_ray;
        private System.Windows.Forms.Label lblgamma_ray;
        private System.Windows.Forms.Label lblphoton;
        private System.Windows.Forms.Label lblelectrons;
        private System.Windows.Forms.Timer gamma_cooldown;
        private System.Windows.Forms.Timer energy_timer;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Timer face_cooldown;
        private System.Windows.Forms.Label lblxp;
        public System.Windows.Forms.Timer radioactive_timer;
    }
}