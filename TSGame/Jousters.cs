using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace TSGame
{
    class Jousters
    {
        public Jousters(PictureBox enemy,  PictureBox sprite, PictureBox health1, PictureBox health2, PictureBox health3, int side)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 35;
            Sprite = sprite;
            Enemy = enemy;
            Health[0] = health1;
            Health[1] = health2;
            Health[2] = health3;

            //Crop Sprite & Health
            if (side == 1)
            {
                Sprite.Image = CropBitmap(Jouster, 0, 0, 144, 138, 1);
                for (int i = 0; i < 3; i++)
                {
                    Health[i].Image = CropBitmap(Shield, 1164, 803, 699, 650, 0);
                }
            }
            else
            {
                Sprite.Image = CropBitmap(Jouster, 0, 755, 144, 138, 0);
                for (int i = 0; i < 3; i++)
                {
                    Health[i].Image = CropBitmap(Shield, 1178, 19, 699, 650, 0);
                }
            }

            idle.PlayLooping();
        }

        public void setRival(Jousters rival)
        {
            Rival = rival;
        }
        public void damage()
        {
            hit.Play();
            Health[0].Image = CropBitmap(Shield, 2103, 56, 699, 650, 0);
        }

        //Controls
        public void moveLeft(object sender, KeyEventArgs e)
        {  
            //Changed these to if so I could test them, using while causes a memory shortage
            if (e.KeyCode == Keys.Left)
            {
                idle.Stop();
                timer.Start();
                moving.Play();
                Sprite.Image = CropBitmap(Jouster, 0, 0, 144, 138, 0);
                Sprite.Location = new Point(Sprite.Location.X + speed, Sprite.Location.Y);
            }
            timer.Stop();
            idle.PlayLooping();

            return;
        }
        public void moveRight(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                idle.Stop();
                timer.Start();
                moving.Play();
                Sprite.Image = CropBitmap(Jouster, 0, 0, 144, 138, 1);
                Sprite.Location = new Point(Sprite.Location.X - speed, Sprite.Location.Y);
            }
            timer.Stop();
            idle.PlayLooping();

            return;
        }
        public void Lance(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                idle.Stop();
                timer.Start();
                lance_drop.Play();
                if (y_anim != 4)
                {
                    y_anim++;
                    Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, 0);
                }
            }
            y_anim--;
            Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, 0);
            timer.Stop();

            return;
        }
        public void Jab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                jab.Play();
                if (Enemy.Location.X - Sprite.Location.X < 220 || Enemy.Location.X - Sprite.Location.X > 200 ||
                    Enemy.Location.X - Sprite.Location.X > -220 || Enemy.Location.X - Sprite.Location.X < -200) Rival.damage();
            }

            return;
        }

        //Image cropping
        private Bitmap CropBitmap(Bitmap image, int cropX, int cropY, int width, int height, int dir)
        {
            Rectangle rect = new Rectangle(cropX, cropY, width, height);
            Bitmap crop = image.Clone(rect,image.PixelFormat);
            if (dir == 1)
            {
                crop.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            return crop;
        }

        //Variables
        private Jousters Rival;
        private Bitmap Jouster = global::TSGame.Properties.Resources.Jousting_Sprite;
        private Bitmap Shield = global::TSGame.Properties.Resources.Shield;
        private SoundPlayer idle = new SoundPlayer(global::TSGame.Properties.Resources.Idle);
        private SoundPlayer moving = new SoundPlayer(global::TSGame.Properties.Resources.Running);
        private SoundPlayer lance_drop = new SoundPlayer(global::TSGame.Properties.Resources.Lance_Drop);
        private SoundPlayer jab = new SoundPlayer(global::TSGame.Properties.Resources.Jab);
        private SoundPlayer hit = new SoundPlayer(global::TSGame.Properties.Resources.Shield_Bash);
        private PictureBox Sprite;
        private PictureBox Enemy;
        private PictureBox[] Health = new PictureBox[3];
        private Timer timer;
        private int state;
        private int x_anim;
        private int y_anim;
        private int speed = 1;
    }
}
