namespace Atom_Care
{
    partial class Form1
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
            this.btnplay = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(60, 137);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(150, 50);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "PLAY";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(32, 193);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(200, 50);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "Explanation and Info";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atom_Care.Properties.Resources.start_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btninfo;
    }
}

