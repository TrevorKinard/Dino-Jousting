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
        public Jousters(PictureBox enemy,  PictureBox sprite, PictureBox health1, PictureBox health2, PictureBox health3, int side)
        {
            Sprite = sprite;
            Enemy = enemy;
            Side = side;
            Health[0] = health1;
            Health[1] = health2;
            Health[2] = health3;

            //Crop Sprite & Health
            if (side == 1)
            {
                x_anim = 0;
                y_anim = 0;
                Sprite.Image = CropBitmap(Jouster, x_anim, y_anim, 144, 138, 1);
                for (int i = 0; i < 3; i++)
                {
                    Health[i].BackgroundImage = CropBitmap(Shield, 1164, 803, 699, 650, 0);
                }
            }
            //AI Crop
            else
            {
                x_anim = 0;
                y_anim = 0;
                Sprite.Image = CropBitmap(Jouster, x_anim, 552, 144, 138, 0);
                for (int i = 0; i < 3; i++)
                {
                    Health[i].BackgroundImage = CropBitmap(Shield, 1178, 19, 699, 650, 0);
                }
            }
            //Screen width
            state = 0;
            idle.PlayLooping();
        }

        public void setRival(Jousters rival)
        {
            Rival = rival;
        }
        public void damage()
        {
            hit.Play();
            Rival.Health[Rival.state].BackgroundImage = CropBitmap(Shield, 2103, 56, 699, 650, 0);
            Rival.state++;
        }

        //Controls
        public void moveLeft(object sender, KeyEventArgs e)
        {
            //Changed these to if so I could test them, using while causes a memory shortage
            if (e.KeyCode == Keys.Left && Sprite.Location.X != 0)
            {
                dir = 0;
                idle.Stop();
                moving.Play();
                x_anim++;
                Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, 0);
                if (x_anim == 3) x_anim = 0;
                Sprite.Location = new Point(Sprite.Location.X - speed, Sprite.Location.Y);

                //AI movement
                if (Sprite.Location.X < formMain.ActiveForm.Width - Sprite.Width * 1.5 && Sprite.Location.X > Sprite.Width * 1.5  && Side == 1)
                {
                    Enemy.Image = Rival.CropBitmap(Jouster, Rival.x_anim * 144, y_anim * 138 + 552, 144, 138, 1);
                    if (Rival.x_anim == 3) Rival.x_anim = 0;
                    Rival.Sprite.Location = new Point(Rival.Sprite.Location.X + speed, Rival.Sprite.Location.Y);
                }

                idle.PlayLooping();
            }

            return;
        }
        public void moveRight(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && formMain.ActiveForm.Width > Sprite.Location.X + Sprite.Width)
            {
                dir = 1;
                idle.Stop();
                moving.Play();      
                x_anim++;
                Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, 1);
                if (x_anim == 3) x_anim = 0;
                Sprite.Location = new Point(Sprite.Location.X + speed, Sprite.Location.Y);

                //AI movement
                 if (Sprite.Location.X > Sprite.Width * 1.5 && Sprite.Location.X < formMain.ActiveForm.Width - Sprite.Width * 1.5 && Side == 1)
                {
                    Enemy.Image = CropBitmap(Jouster, Rival.x_anim * 144, y_anim * 138 + 552, 144, 138, 0);
                    if (Rival.x_anim == 3) Rival.x_anim = 0;
                    Rival.Sprite.Location = new Point(Rival.Sprite.Location.X - speed, Rival.Sprite.Location.Y);
                }

                idle.PlayLooping();
            }

            return;
        }
        public void Lance(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                idle.Stop();
                lance_drop.Play();
                
                if (y_anim != 3)
                {
                    y_anim++;
                    Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, dir);

                    //AI Lance
                    if (Side == 1)
                    {

                        switch (dir)
                        {
                            case 0:
                                Rival.Sprite.Image = CropBitmap(Jouster, Rival.x_anim * 144, y_anim * 138 + 552, 144, 138, 1);
                                break;
                            case 1:
                                Rival.Sprite.Image = CropBitmap(Jouster, Rival.x_anim * 144, y_anim * 138 + 552, 144, 138, 0);
                                break;
                        }
                    }
                }

            else
            {
                while (y_anim != 0)
                {
                    y_anim--;
                    Sprite.Image = CropBitmap(Jouster, x_anim * 144, y_anim * 138, 144, 138, 0);
                }
            }
                idle.PlayLooping();
            }
            return;
        }
        public void Jab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                jab.Play();
                if (Enemy.Location.X - Sprite.Location.X < 220 || Enemy.Location.X - Sprite.Location.X > 200 ||
                    Enemy.Location.X - Sprite.Location.X > -220 || Enemy.Location.X - Sprite.Location.X < -200 && Side == 1) Rival.damage();
            }

            return;
        }

        //Sprite animation rate? need one


            //Image cropping
            private Bitmap CropBitmap(Bitmap image, int cropX, int cropY, int width, int height, int dir)
        {
            Rectangle rect = new Rectangle(cropX, cropY, width, height);
            crop = image.Clone(rect,image.PixelFormat);
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
        private Bitmap crop;
        private SoundPlayer idle = new SoundPlayer(global::TSGame.Properties.Resources.Idle);
        private SoundPlayer moving = new SoundPlayer(global::TSGame.Properties.Resources.Running);
        private SoundPlayer lance_drop = new SoundPlayer(global::TSGame.Properties.Resources.Lance_Drop);
        private SoundPlayer jab = new SoundPlayer(global::TSGame.Properties.Resources.Jab);
        private SoundPlayer hit = new SoundPlayer(global::TSGame.Properties.Resources.Shield_Bash);
        private PictureBox Sprite;
        private PictureBox Enemy;
        public PictureBox[] Health = new PictureBox[3];
        private int Side;
        private int dir;
        private int state;
        private int x_anim;
        private int y_anim;
        private int speed = 5;
    }
}
