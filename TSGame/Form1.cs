using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace TSGame
{

    public partial class formMain : Form
    {
        public static formMain Main;
        public bool pauseMenuOpen = false;
        public bool hasPressedPlay = false;
        private System.Windows.Forms.Timer check = new System.Windows.Forms.Timer();
        Jousters EnJouster;
        Jousters PlJouster;
        int PlOrigin;
        int EnOrigin;
        Point ExitOrigin;
        MediaPlayback BackgroundMusic;


        public formMain()
        {
            InitializeComponent();

            //Merge Image Layers
            PlayerJouster.Parent = EnemyJouster;
            PlayerJouster.Location = new Point(0,0);

            //Initilize Jousters (Opposing Picturebox, Characters Picturebox, Health Icon 1, Health Icon 2, Health Icon 3, Side(player: 0, Opposing: 1))
            PlJouster = new Jousters(this.EnemyJouster, this.PlayerJouster, this.PlayerHealth1, this.PlayerHealth2, this.PlayerHealth3, 0);
            EnJouster = new Jousters(this.PlayerJouster, this.EnemyJouster, this.EnemyHealth1, this.EnemyHealth2, this.EnemyHealth3, 1);

            //Get Original positions for resetting
            PlOrigin = PlJouster.location;
            EnOrigin = EnJouster.location;
            ExitOrigin = buttonExit.Location;

            //Pass the Opposing Jouster
            PlJouster.setRival(EnJouster);
            EnJouster.setRival(PlJouster);

            //Menu background music
            BackgroundMusic = new MediaPlayback();
            BackgroundMusic.PlayAudio(@"C:\Users\rossh\Desktop\Dino-Jousting-master\Sound\Gurdys Green - Patty Gurdy (Hurdy Gurdy Music).wav");

            //Check player Health
            check.Tick += new EventHandler(tick);
            check.Start();

            //Prevents activating the replay button on accident by holding spacebar when the game ends
            buttonExit.DisableSelect();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this.buttonStart.Text == "Start")
            {
                //Take User Input
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(PlJouster.keydown);
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(PlJouster.keyup);

                this.panelStartMenu.Hide();
                this.buttonStart.Text = "Resume";
                hasPressedPlay = true;
            }
            //Change to the resume button after the player presses start
            else if (buttonStart.Text == "Resume")
            {
                this.panelStartMenu.Hide();
                pauseMenuOpen = false;

                //Enable movement once game resumes
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(PlJouster.keydown);
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(PlJouster.keyup);
            }
            else if (buttonStart.Text == "Replay")
            {

                PlayerHealth1.BackgroundImage = PlJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1164, 803, 699, 650, 0);
                PlayerHealth2.BackgroundImage = PlJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1164, 803, 699, 650, 0);
                PlayerHealth3.BackgroundImage = PlJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1164, 803, 699, 650, 0);

                EnemyHealth1.BackgroundImage = EnJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1178, 19, 699, 650, 0);
                EnemyHealth2.BackgroundImage = EnJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1178, 19, 699, 650, 0);
                EnemyHealth3.BackgroundImage = EnJouster.CropBitmap(global::TSGame.Properties.Resources.Shield, 1178, 19, 699, 650, 0);

                PlJouster.state = 0;
                EnJouster.state = 0;

                buttonExit.Location = ExitOrigin;
                PlJouster.location = PlOrigin;
                EnJouster.location = EnOrigin;

                panelWinScreen.SendToBack();

                label3.Text = null;
                buttonOptions.Show();
                hasPressedPlay = false;
                buttonStart.Text = "Start";

                buttonOptions.Show();
                panelWinScreen.Hide();
                label3.Hide();
            }

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            //Options to implement

            if (buttonOptions.Text == "Options")
            {
                buttonStart.Hide();
                buttonOptions.Hide();
                buttonExit.Text = "Back";
                label4.Show();
                trackBarMusicVolume.Show();
            }
        }

        //Close the game when you press exit
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            if (buttonExit.Text == "Exit")
                Close();
            else if (buttonExit.Text == "Back")
            {
                buttonOptions.Text = "Options";
                buttonExit.Text = "Exit";
                buttonStart.Show();
                buttonOptions.Show();
                buttonExit.Show();
                label4.Hide();
                trackBarMusicVolume.Hide();
            }

        }

        //Press Escape to open and close the pause menu
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //Closing the menu
            if (keyData == Keys.Escape && pauseMenuOpen == true && hasPressedPlay == true)
            {

                //Enable movement once game resumes
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(PlJouster.keydown);
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(PlJouster.keyup);

                this.panelStartMenu.Hide();
                pauseMenuOpen = false;
            }
            //Opening the menu 
            else if (keyData == Keys.Escape)
            {
                //Disable movement while the pause screen is open
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(PlJouster.keydown);
                this.KeyUp -= new System.Windows.Forms.KeyEventHandler(PlJouster.keyup);

                this.panelStartMenu.Show();
                pauseMenuOpen = true;
            }
            return base.ProcessDialogKey(keyData);
        }
        private void trackBarMusicVolume_Scroll(object sender, EventArgs e)
        {
        }

        private void tick(object sender, EventArgs e)
        {
            PlJouster.setGamePausedFlag(pauseMenuOpen);
            if (PlJouster.state == 2)
            {
                panelWinScreen.BringToFront();
                panelStartMenu.BringToFront();
                label3.Text = "You Lose";
                buttonStart.Text = "Replay";
                label3.ForeColor = System.Drawing.Color.Black;
                panelWinScreen.BackColor = System.Drawing.Color.Aqua;
                buttonExit.Location = buttonOptions.Location;
                buttonOptions.Hide();
                panelWinScreen.Show();
                label3.Show();
                panelStartMenu.Show();
                pauseMenuOpen = true;
            }
            else if (EnJouster.state == 2)
            {
                panelWinScreen.BringToFront();
                panelStartMenu.BringToFront();
                label3.Text = "You Win";
                buttonStart.Text = "Replay";
                panelWinScreen.BackColor = System.Drawing.Color.Aqua;
                label3.ForeColor = System.Drawing.Color.Black;
                buttonExit.Location = buttonOptions.Location;
                buttonOptions.Hide();
                panelWinScreen.Show();
                label3.Show();
                panelStartMenu.Show();
                pauseMenuOpen = true;
                PlJouster.ismovingleft = false;
                PlJouster.ismovingright = false;
            }
        }

        private void PlayerJouster_Click(object sender, EventArgs e)
        {

        }

        private void EnemyJouster_Click(object sender, EventArgs e)
        {

        }
    }

}
