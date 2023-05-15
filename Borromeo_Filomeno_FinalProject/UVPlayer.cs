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
    public class UVPlayer : Uber_Form_Game
    {
        public string Name { get; set; }
        public int HighScore { get; set; }

        public PictureBox PbPlayer { get; set; }

        public Bullet bullet { get; set; }

        SoundPlayer gunSound = new SoundPlayer(Resources.gunShot);

        SoundPlayer noAmmoSound = new SoundPlayer(Resources.noBullets);


        public void ChangeBulletColor(Label text)
        {
            //Need to make this more pleasing to the eyes shit
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


        public UVPlayer(PictureBox pbPlayer, int speed)
        {
            PbPlayer = pbPlayer;
            PlayerSpeed = speed;
        }

        public static void SpawnAmmoCrate(PictureBox ammoCrate, UVPlayer player)
        {
            Random rnd = new Random();
            SoundPlayer getAmmo = new SoundPlayer(Resources.getAmmoCrate);


            if (ammoCrate.Top > 715)
            {
                ammoCrate.Top = -300;
                ammoCrate.Left = rnd.Next(12, 772);
            }
            else
            {
                ammoCrate.Top += 1;
                if (ammoCrate.Bounds.IntersectsWith(player.PbPlayer.Bounds))
                {
                    getAmmo.Play();
                    ammoCrate.Top = -1000;
                    ammoCrate.Left = rnd.Next(12, 772);
                    player.bullet.BulletCount += (30 - player.bullet.BulletCount);

                }

            }
        }



        public void GameTimerTickEvent(PictureBox pbPlayer, Form form)
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

                bullet.BulletSpeed = 25;
                bullet.PbBullet.Top -= bullet.BulletSpeed;


            }
            else
            {
                bullet.PbBullet.Left = -300;
                bullet.BulletSpeed = 0;
            }

            if (bullet.PbBullet.Top < -26)
            {
                IsShooting = false;
            }






            BulletCollision(Enemies);
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

        public void KeyIsUpEvent(KeyEventArgs e)
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
                IsShooting = true;

                gunSound.Play();
                bullet.BulletCount -= 1;
                bullet.PbBullet.Top = PbPlayer.Top - 10;
                bullet.PbBullet.Left = PbPlayer.Left + 10;
            }

            if (e.KeyCode == Keys.Space && bullet.BulletCount == 0 && !IsShooting)
            {
                noAmmoSound.Play();
            }



        }

        public void BulletCollision(List<UVEnemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                if (bullet.PbBullet.Bounds.IntersectsWith(enemy.PbEnemy.Bounds))
                {
                    Score++;

                    enemy.ResetEnemy();
                    IsShooting = false;
                }
            }


        }


    }
}
