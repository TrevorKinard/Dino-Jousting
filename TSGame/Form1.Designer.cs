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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.EnemyHealth1 = new System.Windows.Forms.PictureBox();
            this.EnemyHealth2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnemyHealth3 = new System.Windows.Forms.PictureBox();
            this.PlayerHealth3 = new System.Windows.Forms.PictureBox();
            this.PlayerHealth2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerHealth1 = new System.Windows.Forms.PictureBox();
            this.PlayerJouster = new System.Windows.Forms.PictureBox();
            this.EnemyJouster = new System.Windows.Forms.PictureBox();
            this.panelGamePlay.SuspendLayout();
            this.panelStartMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerJouster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJouster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGamePlay
            // 
            this.panelGamePlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGamePlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGamePlay.BackgroundImage")));
            this.panelGamePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGamePlay.Controls.Add(this.panelStartMenu);
            this.panelGamePlay.Controls.Add(this.EnemyJouster);
            this.panelGamePlay.Controls.Add(this.EnemyHealth1);
            this.panelGamePlay.Controls.Add(this.EnemyHealth2);
            this.panelGamePlay.Controls.Add(this.label2);
            this.panelGamePlay.Controls.Add(this.EnemyHealth3);
            this.panelGamePlay.Controls.Add(this.PlayerHealth3);
            this.panelGamePlay.Controls.Add(this.PlayerHealth2);
            this.panelGamePlay.Controls.Add(this.label1);
            this.panelGamePlay.Controls.Add(this.PlayerHealth1);
            this.panelGamePlay.Controls.Add(this.PlayerJouster);
            this.panelGamePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGamePlay.Location = new System.Drawing.Point(0, 0);
            this.panelGamePlay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGamePlay.Name = "panelGamePlay";
            this.panelGamePlay.Size = new System.Drawing.Size(1920, 1080);
            this.panelGamePlay.TabIndex = 1;
            // 
            // panelStartMenu
            // 
            this.panelStartMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStartMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelStartMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelStartMenu.Controls.Add(this.buttonExit);
            this.panelStartMenu.Controls.Add(this.buttonOptions);
            this.panelStartMenu.Controls.Add(this.buttonStart);
            this.panelStartMenu.Location = new System.Drawing.Point(325, 155);
            this.panelStartMenu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelStartMenu.Name = "panelStartMenu";
            this.panelStartMenu.Size = new System.Drawing.Size(1272, 768);
            this.panelStartMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic);
            this.buttonExit.Location = new System.Drawing.Point(427, 453);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(416, 103);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic);
            this.buttonOptions.Location = new System.Drawing.Point(427, 336);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(416, 103);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(427, 215);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(416, 107);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // EnemyHealth1
            // 
            this.EnemyHealth1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth1.Location = new System.Drawing.Point(224, 57);
            this.EnemyHealth1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyHealth1.Name = "EnemyHealth1";
            this.EnemyHealth1.Size = new System.Drawing.Size(100, 100);
            this.EnemyHealth1.TabIndex = 11;
            this.EnemyHealth1.TabStop = false;
            // 
            // EnemyHealth2
            // 
            this.EnemyHealth2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth2.Location = new System.Drawing.Point(117, 57);
            this.EnemyHealth2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyHealth2.Name = "EnemyHealth2";
            this.EnemyHealth2.Size = new System.Drawing.Size(100, 100);
            this.EnemyHealth2.TabIndex = 10;
            this.EnemyHealth2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enemy";
            // 
            // EnemyHealth3
            // 
            this.EnemyHealth3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyHealth3.Location = new System.Drawing.Point(11, 57);
            this.EnemyHealth3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyHealth3.Name = "EnemyHealth3";
            this.EnemyHealth3.Size = new System.Drawing.Size(100, 100);
            this.EnemyHealth3.TabIndex = 8;
            this.EnemyHealth3.TabStop = false;
            // 
            // PlayerHealth3
            // 
            this.PlayerHealth3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth3.Location = new System.Drawing.Point(1805, 57);
            this.PlayerHealth3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerHealth3.Name = "PlayerHealth3";
            this.PlayerHealth3.Size = new System.Drawing.Size(100, 100);
            this.PlayerHealth3.TabIndex = 7;
            this.PlayerHealth3.TabStop = false;
            // 
            // PlayerHealth2
            // 
            this.PlayerHealth2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth2.Location = new System.Drawing.Point(1701, 57);
            this.PlayerHealth2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerHealth2.Name = "PlayerHealth2";
            this.PlayerHealth2.Size = new System.Drawing.Size(100, 100);
            this.PlayerHealth2.TabIndex = 6;
            this.PlayerHealth2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1693, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // PlayerHealth1
            // 
            this.PlayerHealth1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealth1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerHealth1.Location = new System.Drawing.Point(1599, 57);
            this.PlayerHealth1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerHealth1.Name = "PlayerHealth1";
            this.PlayerHealth1.Size = new System.Drawing.Size(100, 100);
            this.PlayerHealth1.TabIndex = 4;
            this.PlayerHealth1.TabStop = false;
            // 
            // PlayerJouster
            // 
            this.PlayerJouster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerJouster.BackColor = System.Drawing.Color.Transparent;
            this.PlayerJouster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerJouster.Location = new System.Drawing.Point(1488, 625);
            this.PlayerJouster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerJouster.Name = "PlayerJouster";
            this.PlayerJouster.Size = new System.Drawing.Size(432, 415);
            this.PlayerJouster.TabIndex = 3;
            this.PlayerJouster.TabStop = false;
            // 
            // EnemyJouster
            // 
            this.EnemyJouster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EnemyJouster.BackColor = System.Drawing.Color.Transparent;
            this.EnemyJouster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyJouster.Location = new System.Drawing.Point(0, 625);
            this.EnemyJouster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyJouster.Name = "EnemyJouster";
            this.EnemyJouster.Size = new System.Drawing.Size(432, 415);
            this.EnemyJouster.TabIndex = 2;
            this.EnemyJouster.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelGamePlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGamePlay.ResumeLayout(false);
            this.panelGamePlay.PerformLayout();
            this.panelStartMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerJouster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJouster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStartMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelGamePlay;
        private System.Windows.Forms.PictureBox EnemyJouster;
        private System.Windows.Forms.PictureBox PlayerJouster;
        private System.Windows.Forms.PictureBox EnemyHealth1;
        private System.Windows.Forms.PictureBox EnemyHealth2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EnemyHealth3;
        private System.Windows.Forms.PictureBox PlayerHealth3;
        private System.Windows.Forms.PictureBox PlayerHealth2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PlayerHealth1;
    }
}

