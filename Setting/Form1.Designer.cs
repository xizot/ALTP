namespace Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbSounds = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSounds)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSounds
            // 
            this.pbSounds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSounds.BackgroundImage")));
            this.pbSounds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSounds.Location = new System.Drawing.Point(261, 70);
            this.pbSounds.Name = "pbSounds";
            this.pbSounds.Size = new System.Drawing.Size(38, 33);
            this.pbSounds.TabIndex = 1;
            this.pbSounds.TabStop = false;
            this.pbSounds.Click += new System.EventHandler(this.PbSounds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Âm thanh:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSounds);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSounds;
        private System.Windows.Forms.Label label1;
    }
}

