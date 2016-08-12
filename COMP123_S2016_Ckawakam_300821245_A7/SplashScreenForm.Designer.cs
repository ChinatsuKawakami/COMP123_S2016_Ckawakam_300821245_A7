namespace COMP123_S2016_Ckawakam_300821245_A7
{
    partial class SplashScreenForm
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
            this.SplashScreenFromTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenFromTimer
            // 
            this.SplashScreenFromTimer.Enabled = true;
            this.SplashScreenFromTimer.Interval = 1000;
            this.SplashScreenFromTimer.Tick += new System.EventHandler(this.SplashScreenFromTimer_Tick);
            // 
            // SplashPictureBox
            // 
            this.SplashPictureBox.Image = global::COMP123_S2016_Ckawakam_300821245_A7.Properties.Resources.splashImage;
            this.SplashPictureBox.Location = new System.Drawing.Point(56, 53);
            this.SplashPictureBox.Name = "SplashPictureBox";
            this.SplashPictureBox.Size = new System.Drawing.Size(377, 175);
            this.SplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplashPictureBox.TabIndex = 0;
            this.SplashPictureBox.TabStop = false;
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.Location = new System.Drawing.Point(50, 9);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(385, 32);
            this.SplashLabel.TabIndex = 1;
            this.SplashLabel.Text = "Welcome to Movie Bonanza!";
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.SplashLabel);
            this.Controls.Add(this.SplashPictureBox);
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashScreenFromTimer;
        private System.Windows.Forms.PictureBox SplashPictureBox;
        private System.Windows.Forms.Label SplashLabel;
    }
}