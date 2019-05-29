namespace WhoIsMillionaire
{
    partial class WelcomePL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePL));
            this.pbPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlay
            // 
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlay.BackgroundImage")));
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(347, 335);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(100, 50);
            this.pbPlay.TabIndex = 0;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.PbPlay_Click);
            this.pbPlay.MouseLeave += new System.EventHandler(this.PbPlay_MouseLeave);
            this.pbPlay.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            // 
            // WelcomePL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomePL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePL";
            this.Load += new System.EventHandler(this.WelcomePL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlay;
    }
}