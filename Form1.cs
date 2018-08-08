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
        Jousters EnJouster;
        Jousters PlJousters;
        MediaPlayback BackgroundMusic;


        public formMain()
        {
            InitializeComponent();

            //Merge Image Layers
            PlayerJouster.Parent = EnemyJouster;
            PlayerJouster.Location = new Point(0,0);

            //Initilize Jousters (Opposing Picturebox, Characters Picturebox, Health Icon 1, Health Icon 2, Health Icon 3, Side(player: 0, Opposing: 1))
            Jousters PlJouster = new Jousters(this.EnemyJouster, this.PlayerJouster, this.PlayerHealth1, this.PlayerHealth2, this.PlayerHealth3, 0);
            Jousters EnJouster = new Jousters(this.PlayerJouster, this.EnemyJouster, this.EnemyHealth1, this.EnemyHealth2, this.EnemyHealth3, 1);

            //Take User Input
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(PlJouster.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(PlJouster.keyup);

            //Pass the Opposing Jouster
            PlJouster.setRival(EnJouster);
            EnJouster.setRival(PlJouster);

            //Menu background music
            BackgroundMusic = new MediaPlayback();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if(this.buttonStart.Text == "Start")
            {
                this.panelStartMenu.Hide();
                hasPressedPlay = true;
                this.buttonStart.Text = "Resume";
            }
            else if (EnJouster.state == 2)
            {
                panelWinScreen.BringToFront();
                panelStartMenu.BringToFront();
                panelWinScreen.Show();
                label3.Text = "You Win";
                label3.Show();
                panelWinScreen.BackColor = System.Drawing.Color.Aqua;
                buttonOptions.Hide();
                buttonExit.Location = buttonOptions.Location;
                buttonExit.Show();
                buttonStart.Text = "Replay";
                label3.ForeColor = System.Drawing.Color.Black;
            }
            //Change to the resume button after the player presses start
            else
            {
                this.panelStartMenu.Hide();
                pauseMenuOpen = false;

            }

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            if (buttonOptions.Text == "Options")
            {
                buttonStart.Hide();
                buttonOptions.Hide();
                buttonExit.Text = "Back";
                label4.Show();
                trackBarMusicVolume.Show();

            }
            //Options to implement
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
            if (keyData == Keys.Escape && pauseMenuOpen == true && hasPressedPlay == true)
            {
                this.panelStartMenu.Hide();
                pauseMenuOpen = false;
            }
            else if (keyData == Keys.Escape)
            {
                this.panelStartMenu.Show();
                pauseMenuOpen = true;
            }
            return base.ProcessDialogKey(keyData);
        }
        private void trackBarMusicVolume_Scroll(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            BackgroundMusic.Volume = ((double)trackBarMusicVolume.Value / 10);
            BackgroundMusic.PlayAudio(@"C:\Users\rossh\Documents\GitHub\Dino-Jousting\TSGame\Sound\Gurdys Green - Patty Gurdy (Hurdy Gurdy Music).wav");
            // TimeSpan MusicTime = BackgroundMusic.Position;
            // BackgroundMusic.Position = MusicTime;

        }
    }

}
