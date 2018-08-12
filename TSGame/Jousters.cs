using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace TSGame
{
    class Jousters
    {
        public Jousters(PictureBox enemy, PictureBox sprite, PictureBox health1, PictureBox health2, PictureBox health3, int side)
        {
            Sprite = sprite;
            Enemy = enemy;
            Side = side;
            Health[0] = health1;
            Health[1] = health2;
            Health[2] = health3;

            Sprite.Paint += new System.Windows.Forms.PaintEventHandler(sprite_paint);

            x_anim = 0;
            y_anim = 0;

            //AI
            if (side == 1)
            {
                dir = 1;
                location = 0;
                for (int i = 0; i < 3; i++)
                {
                    Health[i].BackgroundImage = CropBitmap(Shield, 1178, 19, 699, 650, 0);
                }
            }
            //Player
            else
            {
                dir = 0;
                location = -200;
                for (int i = 0; i < 3; i++)
                {
                    Health[i].BackgroundImage = CropBitmap(Shield, 1164, 803, 699, 650, 0);
                }
            }
            CropBitmap(Jouster, 0, 0, 144, 138, 0);
            Sprite.Refresh();
            delay.Tick += new System.EventHandler(tick);
            delay.Interval = 35;
            delay.Start();
            state = 0;
        }

        //Grab Rival
        public void setRival(Jousters rival)
        {
            Rival = rival;
        }
        public void damage()
        {
            hit.Play();

            if (state < 2)
                Health[state].BackgroundImage = CropBitmap(Shield, 2103, 56, 699, 650, 0);
            state++;
            Sprite.Refresh();
            Enemy.Refresh();
        }

        //Controls
        public void keydown(object sender, KeyEventArgs e)
        {
            idle.Stop();
                if ((e.KeyCode == Keys.Left || ismovingleft) && location > 0)
                {
                    ismovingleft = true;
                    Rival.ismovingright = true;
                    Rival.dir = 1;
                    dir = 0;
                    move();
                }
                if ((e.KeyCode == Keys.Right || ismovingright) && formMain.ActiveForm.Width > location + 144)
                {
                    ismovingright = true;
                    Rival.ismovingleft = true;
                    Rival.dir = 0;
                    dir = 1;
                    move();
                }
                if (e.KeyCode == Keys.Space || islancing)
                {
                    islancing = true;
                    lance();
                }
                if (e.KeyCode == Keys.Up && islancing)
                {
                    attack();
                }               

            idle.PlayLooping();
        }
        public void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ismovingleft = false;
                Rival.ismovingright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                ismovingright = false;
                Rival.ismovingleft = false;
            }
            if (e.KeyCode == Keys.Space && y_anim != 0)
            {
                islancing = false;
                while (y_anim != 0)
                {
                    y_anim--;
                    Rival.y_anim--;
                    Sprite.Refresh();
                    Enemy.Refresh();
                }
            }
        }

        //Animations
        private void move()
        {
            moving.Play();
            x_anim++;
            Sprite.Refresh();
            if (x_anim == 3) x_anim = 0;

            //AI movement
            if (location < formMain.ActiveForm.Size.Width - 144 * 1.5 && location > 144 * 1.5)
            {
                Rival.x_anim++;
                Enemy.Refresh();
                if (Rival.x_anim == 3) Rival.x_anim = 0;
            }
        }
        private void lance()
        {
            if (y_anim != 3)
            {
                lance_drop.Play();
                y_anim++;
                Rival.y_anim++;
                Sprite.Refresh();
                Enemy.Refresh();
            }
        }
        private void attack()
        {
            jab.Play();
            if (Rival.location - location < 144 * .6 &&
                Rival.location - location > 144 * .4 || location - Rival.location < 144 * .6 &&
                location - Rival.location > 144 * .4) Rival.damage();
        }

        //Sprite animation rate
        private void tick(object sender, EventArgs e)
        {
            if (location == -200) location = formMain.ActiveForm.Width - 144;
            if (ismovingleft && location > 0) move();
            if (ismovingright && formMain.ActiveForm.Width > location + 144) move();
            if (islancing)
            {
                lance();
                //AI Attack
                if (Side == 1 && Rival.location - location < 144 * .6 &&
                Rival.location - location > 144 * .4 || location - Rival.location < 144 * .6 &&
                location - Rival.location > 144 * .4)
                {
                    jab.Play();
                    Random rand = new Random();
                    int ranum = rand.Next(0, 10);
                    if (ranum == 0) damage();                     
                }
            }
        }

        //Image cropping
        public Bitmap CropBitmap(Bitmap image, int cropX, int cropY, int width, int height, int dir)
        {
            Rectangle rect = new Rectangle(cropX, cropY, width, height);
            crop = image.Clone(rect, image.PixelFormat);
            if (dir == 1)
            {
                crop.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            return crop;
        }

        //Image Update
        private void sprite_paint(object sender, PaintEventArgs e)
        {
                if (ismovingright && location + 144 < formMain.ActiveForm.Width)
                {
                    location = location + speed;
                }
                else if (ismovingleft && location > 0)
                {
                    location = location - speed;
                }
                if (Side == 1)
                    e.Graphics.DrawImage(CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, dir), location, 0, crop.Width, crop.Height);
                else
                e.Graphics.DrawImage(CropBitmap(Jouster, x_anim * 144, y_anim * 138 + 552, 144, 138, dir), location, 0, crop.Width, crop.Height);
        }

        //Variables
        private Jousters Rival;
        private Bitmap Jouster = global::TSGame.Properties.Resources.Jousting_Sprite;
        private Bitmap Shield = global::TSGame.Properties.Resources.Shield;
        private Bitmap crop;
        private SoundPlayer moving = new SoundPlayer(global::TSGame.Properties.Resources.Running);
        private SoundPlayer lance_drop = new SoundPlayer(global::TSGame.Properties.Resources.Lance_Drop);
        private SoundPlayer jab = new SoundPlayer(global::TSGame.Properties.Resources.Jab);
        private SoundPlayer hit = new SoundPlayer(global::TSGame.Properties.Resources.Shield_Bash);
        private PictureBox Sprite;
        private PictureBox Enemy;
        private PictureBox[] Health = new PictureBox[3];
        private Timer delay = new System.Windows.Forms.Timer();
        private int speed = 5;
        private int Side;

        public SoundPlayer idle = new SoundPlayer(global::TSGame.Properties.Resources.Idle);
        public int location;
        public int state;
        public int x_anim;
        public int y_anim;
        public int dir;
        public bool ismovingleft;
        public bool ismovingright;
        public bool islancing;
    }
}
