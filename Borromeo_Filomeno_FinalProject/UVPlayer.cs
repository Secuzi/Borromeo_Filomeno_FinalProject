using Borromeo_Filomeno_FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class UVPlayer
    {
        public bool IsGameOver { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsShooting { get; set; }
        public int PlayerSpeed { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        public int HighScore { get; set; }
        public Bullet bullet;


        public void ChangeBulletColor(Label text)
        {
            //Gradually changes the color to red depending on the bullet count

            if (bullet.BulletCount <= 30 && bullet.BulletCount > 23)
                text.ForeColor = Color.White;
            else if (bullet.BulletCount == 23)
                text.ForeColor = Color.FromArgb(253, 242, 242);
            else if (bullet.BulletCount == 22)
                text.ForeColor = Color.FromArgb(251, 229, 229);
            else if (bullet.BulletCount == 21)
                text.ForeColor = Color.FromArgb(249, 215, 215);
            else if (bullet.BulletCount == 20)
                text.ForeColor = Color.FromArgb(247, 202, 201);
            else if (bullet.BulletCount == 19)
                text.ForeColor = Color.FromArgb(245, 190, 190);
            else if (bullet.BulletCount == 18)
                text.ForeColor = Color.FromArgb(242, 178, 178);
            else if (bullet.BulletCount == 17)
                text.ForeColor = Color.FromArgb(240, 166, 166);
            else if (bullet.BulletCount == 16)
                text.ForeColor = Color.FromArgb(238, 153, 153);
            else if (bullet.BulletCount == 15)
                text.ForeColor = Color.FromArgb(236, 141, 141);
            else if (bullet.BulletCount == 14)
                text.ForeColor = Color.FromArgb(234, 129, 129);
            else if (bullet.BulletCount == 13)
                text.ForeColor = Color.FromArgb(232, 116, 116);
            else if (bullet.BulletCount == 12)
                text.ForeColor = Color.FromArgb(230, 104, 104);
            else if (bullet.BulletCount == 11)
                text.ForeColor = Color.FromArgb(228, 92, 92);
            else if (bullet.BulletCount == 10)
                text.ForeColor = Color.FromArgb(226, 80, 80);
            else if (bullet.BulletCount == 9)
                text.ForeColor = Color.FromArgb(223, 68, 68);
            else if (bullet.BulletCount == 8)
                text.ForeColor = Color.FromArgb(221, 56, 56);
            else if (bullet.BulletCount == 7)
                text.ForeColor = Color.FromArgb(219, 44, 44);
            else if (bullet.BulletCount == 6)
                text.ForeColor = Color.FromArgb(217, 32, 32);
            else if (bullet.BulletCount == 5)
                text.ForeColor = Color.FromArgb(215, 20, 20);
            else if (bullet.BulletCount == 4)
                text.ForeColor = Color.FromArgb(213, 8, 8);
            else if (bullet.BulletCount == 3)
                text.ForeColor = Color.FromArgb(211, 12, 12);
            else if (bullet.BulletCount == 3)
                text.ForeColor = Color.FromArgb(211, 12, 12);
            else
                text.ForeColor = Color.FromArgb(209, 0, 0);

        }

        public UVPlayer()
        {

        }


        public UVPlayer(int speed)
        {
            PlayerSpeed = speed;
        }

        public static void SpawnAmmoCrate(PictureBox ammoCrate, PictureBox pbPlayer, UVPlayer player)
        {
            Random rnd = new Random();
            SoundPlayer getAmmo = new SoundPlayer(Resources.getAmmoCrate);

            //If the player can't get the ammo crate and it exceeds 715 then it will reset it's y position.
            if (ammoCrate.Top > 715)
            {
                ammoCrate.Top = -300;
                ammoCrate.Left = rnd.Next(12, 772);
            }
            else
            {
                //Else the ammoCrate will continue to move.
                ammoCrate.Top += 1;
                if (ammoCrate.Bounds.IntersectsWith(pbPlayer.Bounds))
                {
                    getAmmo.Play();
                    ammoCrate.Top = -1000;
                    ammoCrate.Left = rnd.Next(12, 772);
                    player.bullet.BulletCount += (30 - player.bullet.BulletCount);

                }

            }
        }



        public void GameTimerTickEvent(PictureBox pbPlayer, Form form, List<PictureBox> enemies, PictureBox pbBullet)
        {
            if (IsMovingLeft == true && pbPlayer.Left > 12)
            {
                pbPlayer.Left -= PlayerSpeed;

            }

            if (IsMovingRight == true && pbPlayer.Left < 772)
            {
                pbPlayer.Left += PlayerSpeed;
            }

            if (IsShooting)
            {
                //If IsShooting is true then the bullet will travel 25 pixels per gameTimer interval
                bullet.BulletSpeed = 25;
                pbBullet.Top -= bullet.BulletSpeed;


            }
            else
            {
                //If shooting is false then the picture bullet will leave the canvas
                pbBullet.Left = -300;
                bullet.BulletSpeed = 0;
            }

            if (pbBullet.Top < -26)
            {
                //If the bullet leaves the canvas the IsShooting is false to negate spamming the attack button.
                IsShooting = false;
            }





            //Checks if the bullet collides with the enemy
            BulletCollision(enemies, pbBullet);
            form.Invalidate();
        }


        public void KeyIsDownEvent(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                IsMovingRight = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                IsMovingLeft = true;
            }




        }

        public void KeyIsUpEvent(KeyEventArgs e, PictureBox pbPlayer, PictureBox pbBullet)
        {
            if (e.KeyCode == Keys.Right)
            {
                IsMovingRight = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                IsMovingLeft = false;
            }



            if (e.KeyCode == Keys.Space && bullet.BulletCount > 0 && !IsShooting)
            {
                //When IsShooting is true it will then go to the GamerTickTimer event and will continue to move until it intersects with an enemy
                //Or when it leaves the canvas.
                IsShooting = true;
                SoundPlayer gunSound = new SoundPlayer(Resources.gunShot);
                gunSound.Play();
                bullet.BulletCount -= 1;

                //This makes the bullet project in front of the player
                pbBullet.Top = pbPlayer.Top - 10;
                pbBullet.Left = pbPlayer.Left + 10;
            }



            //Plays a sound if there are no bullets left.
            if (e.KeyCode == Keys.Space && bullet.BulletCount == 0 && !IsShooting)
            {
                SoundPlayer noAmmoSound = new SoundPlayer(Resources.noBullets);
                noAmmoSound.Play();
            }



        }

        public void BulletCollision(List<PictureBox> pbEnemies, PictureBox pbBullet)
        {           
            UVEnemy small = new UVEnemySmall();
            UVEnemy medium = new UVEnemyMedium();
            UVEnemyBig big = new UVEnemyBig();




            foreach (var enemy in pbEnemies)
            {
                if (pbBullet.Bounds.IntersectsWith(enemy.Bounds))
                {
                    Score++;

                    if ((string)enemy.Tag == "enemySmall")
                    {
                        small.ResetEnemy(enemy);
                    }
                    else if ((string)enemy.Tag == "enemyMedium")
                    {
                        medium.ResetEnemy(enemy);
                    }
                    else
                    {
                        big.ResetEnemy(enemy);
                    }



                    //IsShooting is set to false so that it when the bullet collides with the enemy
                    //The bullet also disappears and lets you shoot again
                    IsShooting = false;
                }
            }

        }
    }
}
