namespace Borromeo_Filomeno_FinalProject
{
    partial class UberGameHomepage
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
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.timerHomePageUB = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Font = new System.Drawing.Font("Squarish Sans CT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.lblPlay.Location = new System.Drawing.Point(344, 258);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(121, 48);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.Text = "PLAY";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Squarish Sans CT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.lblHelp.Location = new System.Drawing.Point(341, 359);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(127, 48);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "HELP";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Squarish Sans CT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.lblExit.Location = new System.Drawing.Point(351, 461);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(107, 48);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "EXIT";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // timerHomePageUB
            // 
            this.timerHomePageUB.Interval = 15;
            this.timerHomePageUB.Tick += new System.EventHandler(this.timerHomePageUB_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.playerIdle;
            this.pbPlayer.Location = new System.Drawing.Point(388, 556);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(32, 48);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Squarish Sans CT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(681, 132);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "UBER VOID";
            // 
            // UberGameHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borromeo_Filomeno_FinalProject.Properties.Resources.UBHomepageBG;
            this.ClientSize = new System.Drawing.Size(809, 647);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UberGameHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UberGameHomepage";
            this.Load += new System.EventHandler(this.UberGameHomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Timer timerHomePageUB;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblTitle;
    }
}