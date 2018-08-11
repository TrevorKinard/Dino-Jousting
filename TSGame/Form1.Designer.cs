namespace TSGame
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelGamePlay = new System.Windows.Forms.Panel();
            this.panelStartMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarMusicVolume = new System.Windows.Forms.TrackBar();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.PlayerJouster = new System.Windows.Forms.PictureBox();
            this.EnemyHealth1 = new System.Windows.Forms.PictureBox();
            this.EnemyHealth2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnemyHealth3 = new System.Windows.Forms.PictureBox();
            this.PlayerHealth3 = new System.Windows.Forms.PictureBox();
            this.PlayerHealth2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerHealth1 = new System.Windows.Forms.PictureBox();
            this.EnemyJouster = new System.Windows.Forms.PictureBox();
            this.panelWinScreen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGamePlay.SuspendLayout();
            this.panelStartMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerJouster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJouster)).BeginInit();
            this.panelWinScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGamePlay
            // 
            this.panelGamePlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGamePlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGamePlay.BackgroundImage")));
            this.panelGamePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGamePlay.Controls.Add(this.panelStartMenu);
            this.panelGamePlay.Controls.Add(this.PlayerJouster);
            this.panelGamePlay.Controls.Add(this.EnemyHealth1);
            this.panelGamePlay.Controls.Add(this.EnemyHealth2);
            this.panelGamePlay.Controls.Add(this.label2);
            this.panelGamePlay.Controls.Add(this.EnemyHealth3);
            this.panelGamePlay.Controls.Add(this.PlayerHealth3);
            this.panelGamePlay.Controls.Add(this.PlayerHealth2);
            this.panelGamePlay.Controls.Add(this.label1);
            this.panelGamePlay.Controls.Add(this.PlayerHealth1);
            this.panelGamePlay.Controls.Add(this.EnemyJouster);
            this.panelGamePlay.Controls.Add(this.panelWinScreen);
            this.panelGamePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGamePlay.Location = new System.Drawing.Point(0, 0);
            this.panelGamePlay.Name = "panelGamePlay";
            this.panelGamePlay.Size = new System.Drawing.Size(720, 453);
            this.panelGamePlay.TabIndex = 1;
            // 
            // panelStartMenu
            // 
            this.panelStartMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStartMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelStartMenu.Controls.Add(this.label4);
            this.panelStartMenu.Controls.Add(this.trackBarMusicVolume);
            this.panelStartMenu.Controls.Add(this.buttonExit);
            this.panelStartMenu.Controls.Add(this.buttonOptions);
            this.panelStartMenu.Controls.Add(this.buttonStart);
            this.panelStartMenu.Location = new System.Drawing.Point(205, 113);
            this.panelStartMenu.Name = "panelStartMenu";
            this.panelStartMenu.Size = new System.Drawing.Size(286, 201);
            this.panelStartMenu.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(37, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Music Volume";
            this.label4.Visible = false;
            // 
            // trackBarMusicVolume
            // 
            this.trackBarMusicVolume.Location = new System.Drawing.Point(43, 73);
            this.trackBarMusicVolume.Name = "trackBarMusicVolume";
            this.trackBarMusicVolume.Size = new System.Drawing.Size(205, 45);
            this.trackBarMusicVolume.TabIndex = 3;
            this.trackBarMusicVolume.Value = 5;
            this.trackBarMusicVolume.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic);
            this.buttonExit.Location = new System.Drawing.Point(65, 124);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(156, 43);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonOptions.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic);
            this.buttonOptions.Location = new System.Drawing.Point(65, 75);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(156, 43);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(65, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // PlayerJouster
            // 
            this.PlayerJouster.BackColor = System.Drawing.Color.Transparent;
            this.PlayerJouster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerJouster.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerJouster.Location = new System.Drawing.Point(0, 0);
            this.PlayerJouster.Margin = new System.Windows.Forms.Padding(1);
            this.PlayerJouster.Name = "PlayerJouster";
            this.PlayerJouster.Size = new System.Drawing.Size(720, 262);
            this.PlayerJouster.TabIndex = 2;
            this.PlayerJouster.TabStop = false;
            // 
            // EnemyHealth1
            // 
            this.EnemyHealth1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth1.Location = new System.Drawing.Point(84, 24);
            this.EnemyHealth1.Margin = new System.Windows.Forms.Padding(1);
            this.EnemyHealth1.Name = "EnemyHealth1";
            this.EnemyHealth1.Size = new System.Drawing.Size(38, 42);
            this.EnemyHealth1.TabIndex = 11;
            this.EnemyHealth1.TabStop = false;
            // 
            // EnemyHealth2
            // 
            this.EnemyHealth2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth2.Location = new System.Drawing.Point(44, 24);
            this.EnemyHealth2.Margin = new System.Windows.Forms.Padding(1);
            this.EnemyHealth2.Name = "EnemyHealth2";
            this.EnemyHealth2.Size = new System.Drawing.Size(38, 42);
            this.EnemyHealth2.TabIndex = 10;
            this.EnemyHealth2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enemy";
            // 
            // EnemyHealth3
            // 
            this.EnemyHealth3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth3.Location = new System.Drawing.Point(4, 24);
            this.EnemyHealth3.Margin = new System.Windows.Forms.Padding(1);
            this.EnemyHealth3.Name = "EnemyHealth3";
            this.EnemyHealth3.Size = new System.Drawing.Size(38, 42);
            this.EnemyHealth3.TabIndex = 8;
            this.EnemyHealth3.TabStop = false;
            // 
            // PlayerHealth3
            // 
            this.PlayerHealth3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth3.Location = new System.Drawing.Point(677, 24);
            this.PlayerHealth3.Margin = new System.Windows.Forms.Padding(1);
            this.PlayerHealth3.Name = "PlayerHealth3";
            this.PlayerHealth3.Size = new System.Drawing.Size(38, 42);
            this.PlayerHealth3.TabIndex = 7;
            this.PlayerHealth3.TabStop = false;
            // 
            // PlayerHealth2
            // 
            this.PlayerHealth2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth2.Location = new System.Drawing.Point(638, 24);
            this.PlayerHealth2.Margin = new System.Windows.Forms.Padding(1);
            this.PlayerHealth2.Name = "PlayerHealth2";
            this.PlayerHealth2.Size = new System.Drawing.Size(38, 42);
            this.PlayerHealth2.TabIndex = 6;
            this.PlayerHealth2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // PlayerHealth1
            // 
            this.PlayerHealth1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth1.Location = new System.Drawing.Point(600, 24);
            this.PlayerHealth1.Margin = new System.Windows.Forms.Padding(1);
            this.PlayerHealth1.Name = "PlayerHealth1";
            this.PlayerHealth1.Size = new System.Drawing.Size(38, 42);
            this.PlayerHealth1.TabIndex = 4;
            this.PlayerHealth1.TabStop = false;
            // 
            // EnemyJouster
            // 
            this.EnemyJouster.BackColor = System.Drawing.Color.Transparent;
            this.EnemyJouster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyJouster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EnemyJouster.Location = new System.Drawing.Point(0, 262);
            this.EnemyJouster.Margin = new System.Windows.Forms.Padding(1);
            this.EnemyJouster.Name = "EnemyJouster";
            this.EnemyJouster.Size = new System.Drawing.Size(720, 191);
            this.EnemyJouster.TabIndex = 3;
            this.EnemyJouster.TabStop = false;
            // 
            // panelWinScreen
            // 
            this.panelWinScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelWinScreen.Controls.Add(this.label3);
            this.panelWinScreen.Location = new System.Drawing.Point(-14, 0);
            this.panelWinScreen.Name = "panelWinScreen";
            this.panelWinScreen.Size = new System.Drawing.Size(734, 453);
            this.panelWinScreen.TabIndex = 12;
            this.panelWinScreen.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 40.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(250, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 67);
            this.label3.TabIndex = 0;
            this.label3.Text = "You Win";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(720, 453);
            this.Controls.Add(this.panelGamePlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGamePlay.ResumeLayout(false);
            this.panelGamePlay.PerformLayout();
            this.panelStartMenu.ResumeLayout(false);
            this.panelStartMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerJouster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJouster)).EndInit();
            this.panelWinScreen.ResumeLayout(false);
            this.panelWinScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStartMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelGamePlay;
        private System.Windows.Forms.PictureBox PlayerJouster;
        private System.Windows.Forms.PictureBox EnemyJouster;
        private System.Windows.Forms.PictureBox EnemyHealth1;
        private System.Windows.Forms.PictureBox EnemyHealth2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EnemyHealth3;
        private System.Windows.Forms.PictureBox PlayerHealth3;
        private System.Windows.Forms.PictureBox PlayerHealth2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PlayerHealth1;
        private System.Windows.Forms.Panel panelWinScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarMusicVolume;
        private System.Windows.Forms.Label label4;
    }
}

