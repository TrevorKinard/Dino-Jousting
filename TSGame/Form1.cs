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

        public formMain()
        {
            InitializeComponent();
            Jousters EnJouster = new Jousters(this.PlayerJouster, this.EnemyJouster, this.EnemyHealth1, this.EnemyHealth2, this.EnemyHealth3, 1);
            Jousters PlJouster = new Jousters(this.EnemyJouster,  this.PlayerJouster, this.PlayerHealth1, this.PlayerHealth2, this.PlayerHealth3, 0);

            this.KeyDown += new KeyEventHandler(EnJouster.moveLeft);
            this.KeyDown += new KeyEventHandler(EnJouster.moveRight);
            this.KeyDown += new KeyEventHandler(EnJouster.Jab);
            this.KeyDown += new KeyEventHandler(EnJouster.Lance);
            PlJouster.setRival(EnJouster);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::TSGame.Properties.Resources.Gurdys_Green___Patty_Gurdy__Hurdy_Gurdy_Music_);
            player.PlayLooping();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if(this.buttonStart.Text == "Start")
            {
                this.panelStartMenu.Hide();
                hasPressedPlay = true;
                this.buttonStart.Text = "Resume";
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
            //Options to implement
        }

        //Close the game when you press exit
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
    }

}
