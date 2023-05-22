using Borromeo_Filomeno_FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public abstract class UVEnemy : Uber_Form_Game
    {
        public int EnemySpeed { get; set; }
        public static void IsColliding(PictureBox player, Uber_Form_Game game, List<PictureBox> enemies)
        {

            foreach (var enemy in enemies)
            {
                if (player.Bounds.IntersectsWith(enemy.Bounds))
                {
                    SoundPlayer explosionSound = new SoundPlayer(Resources.explosionsound);
                    explosionSound.Play();
                    game.IsGameOver = true;

                }
            }



        }


        public abstract void ResetEnemy(PictureBox enemy);


        public static void ResetEnemies(List<PictureBox> enemies)
        {
            Random rnd = new Random();

            foreach (var enemy in enemies)
            {
                if ((string)enemy.Tag == "enemySmall")
                {
                    //top 50
                    enemy.Left = rnd.Next(12, 772);
                    enemy.Top = rnd.Next(0, 1600) * -1;
                }

                if ((string)enemy.Tag == "enemyMedium")
                {
                    //top 60
                    enemy.Left = rnd.Next(12, 740);
                    enemy.Top = rnd.Next(0, 1200) * -1;
                }

                if ((string)enemy.Tag == "enemyBig")
                {
                    //top 100
                    enemy.Left = rnd.Next(12, 752);
                    enemy.Top = rnd.Next(0, 1000) * -1;
                }

            }


        }

        public static void EnemyMovement(PictureBox player, Uber_Form_Game game, List<PictureBox> enemies)
        {
            UVEnemy big = new UVEnemyBig();
            UVEnemy medium = new UVEnemyMedium();
            UVEnemy small = new UVEnemySmall();

            foreach (var enemy in enemies)
            {
                //changes
                enemy.Visible = true;
                IsColliding(player, game, enemies);


                if (enemy.Top > 712)
                {
                    if ((string)enemy.Tag == "enemySmall")
                    {
                        small.ResetEnemy(enemy);

                    }

                    if ((string)enemy.Tag == "enemyMedium")
                    {

                        medium.ResetEnemy(enemy);
                    }

                    if ((string)enemy.Tag == "enemyBig")
                    {
                        big.ResetEnemy(enemy);

                    }
                }

                if ((string)enemy.Tag == "enemySmall")
                {
                    small.SetEnemySpeed(4);
                    small.MoveEnemy(enemy);

                }

                if ((string)enemy.Tag == "enemyBig")
                {
                    big.SetEnemySpeed(2);
                    big.MoveEnemy(enemy);

                }

                if ((string)enemy.Tag == "enemyMedium")
                {
                    medium.SetEnemySpeed(3);
                    medium.MoveEnemy(enemy);

                }


            }
        }


        public UVEnemy()
        {

        }

        public abstract void SetEnemySpeed(int speed);

        #region lastTime
        public static List<PictureBox> SortEnemies(Control.ControlCollection Controls)
        {
            List<PictureBox> list = new List<PictureBox>();
            foreach (var ctr in Controls)
            {
                PictureBox enemy = ctr as PictureBox;

                if (enemy != null)
                {
                    if ((string)enemy.Tag == "enemySmall")
                    {
                        list.Add(enemy);
                    }
                    if ((string)enemy.Tag == "enemyMedium")
                    {
                        list.Add(enemy);
                    }

                    if ((string)enemy.Tag == "enemyBig")
                    {
                        list.Add(enemy);
                    }

                }


            }

            return list;
        }
        #endregion


        public abstract void MoveEnemy(PictureBox enemy);



    }
}
