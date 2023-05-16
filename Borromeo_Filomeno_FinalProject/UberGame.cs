using Borromeo_Filomeno_FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class UberGame : Form
    {
        clsDatabase uberGameData;
        public string User { get; set; }
        public List<clsAccount> accounts;
      

        UVPlayer player;
        Uber_Form_Game game = new Uber_Form_Game();
        Bullet bullet = new Bullet();
        public UberGame()
        {
            InitializeComponent();
            uberGameData = new clsDatabase();
            accounts = new List<clsAccount>(uberGameData.GetAccountsInDatabase());
            User = uberGameData.GetAccountFromForm();


            GameStart();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //When the left or right arrow is held then the player will move acordingly
            player.KeyIsUpEvent(e);
            if (e.KeyCode == Keys.Enter && game.IsGameOver)
            {
                pbResume.Enabled = true;
                lblGameOver.Visible = false;            
                lblRestart.Visible = false;
                GameStart();
            }
        }
        


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //When the left or right arrow is held then the player will move acordingly
            player.KeyIsDownEvent(e);

            if (e.KeyCode == Keys.Escape)
            {
                if (game.IsGameOver)
                {
                    pbResume.Enabled = false;
                    panelOptions.Enabled = true;
                    panelOptions.Visible = true;
                    panelOptions.BringToFront();
                }
                else
                {
                    panelOptions.Enabled = !panelOptions.Enabled;
                    panelOptions.Visible = !panelOptions.Visible;
                    panelOptions.BringToFront();

                    if (panelOptions.Visible)
                    {
                        timerGame.Stop();
                    }
                    else
                    {
                        timerGame.Start();
                    }
                }

                

            }
        }


        private void GameStart()
        {
            Cursor customCursor = new Cursor(Resources.sCursor.GetHicon());
            this.Cursor = customCursor;

            
            panelOptions.Enabled = false;
            panelOptions.Visible = false;

            game.IsGameOver = false;
            pbPlayer.Image = Resources.playerIdle;
            
            clsAccount playerG = new clsAccount();
                                                       //Change this to User if production na
            playerG = accounts.Find(a => a.Username == User || a.Email == User);

            player = new UVPlayer(pbPlayer, 10);



            player.Name = User;
            player.HighScore = playerG.Score;

            player.IsShooting = false;
            player.bullet = bullet;
            UVEnemy.SortEnemies(this.Controls);
            UVEnemy.ResetEnemies();
            player.Score = 0;
            bullet.PbBullet = pbBullet;
            bullet.BulletSpeed = 0;
            bullet.PbBullet.Left = -300;
            pbAmmoCrate.Top = -500;
            bullet.BulletCount = 30;
            lblBulletCount.Text = bullet.BulletCount.ToString();
            lblScore.Text = player.Score.ToString();
            #region IfThingsGoBad

            //foreach (var enemy in this.Controls)
            //{


            //    if (enemy is PictureBox)
            //    {
            //        var pbEnemy = (PictureBox)enemy;


            //        if ((string)pbEnemy.Tag == "enemyBig")
            //        {
            //            enemies.Add(new UVEnemyBig((string)pbEnemy.Tag));
            //            pbEnemies.Add(pbEnemy);
            //        }

            //        if ((string)pbEnemy.Tag == "enemyMedium")
            //        {
            //            enemies.Add(new UVEnemyMedium((string)pbEnemy.Tag));
            //            pbEnemies.Add(pbEnemy);
            //        }

            //        if ((string)pbEnemy.Tag == "enemySmall")
            //        {
            //            enemies.Add(new UVEnemySmall((string)pbEnemy.Tag));
            //            pbEnemies.Add(pbEnemy);
            //        }


            //    }



            //}
            #endregion

            timerGame.Start();


        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            //Need to implement the database to see the highscore...

            if (game.IsGameOver == true)
            {
                timerGame.Stop();
                if (player.Score > player.HighScore)
                {
                    player.HighScore = player.Score;
                                             //Change secuzi to User if production na
                    uberGameData.ScoreChanges(User, player.HighScore, accounts);
                }

                pbPlayer.Image = Resources.explosion;
                lblGameOver.Visible = true;
                panelOptions.BringToFront();
                panelOptions.Enabled = true;
                panelOptions.Visible = true;
                lblRestart.Visible = true;
                
                
            }
            else
            {
                player.GameTimerTickEvent(pbPlayer, this);
                UVEnemy.EnemyMovement(player, game);
                UVPlayer.SpawnAmmoCrate(pbAmmoCrate, player);
                player.ChangeBulletColor(lblBulletCount);

                pbBg0.Top += 3;
                pbBg1.Top += 3;

                if (pbBg0.Top > 713)
                {
                    pbBg0.Top = -713;

                }

                if (pbBg1.Top > 713)
                {
                    pbBg1.Top = -713;

                }

                lblScore.Text = player.Score.ToString();
                lblHighscore.Text = player.HighScore.ToString();
                lblCurrentScore.Text = lblScore.Text;
                lblBulletCount.Text = bullet.BulletCount.ToString();
            }

            this.Invalidate();


            //Put game timer

            //Add enemy movement


            //Remove the foreach and replace it with just enemy.SetEnemySpeed and MoveEnemy function and also keep the if enemy is small etc.




        }

        private void pbResume_Click(object sender, EventArgs e)
        {
            if (panelOptions.Visible)
            {
                panelOptions.Enabled = false;
                panelOptions.Visible = false;
                timerGame.Start();
                
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {

            if (player.Score > player.HighScore)
            {
                player.HighScore = player.Score;
                                          //Change this to User when production na
                uberGameData.ScoreChanges(User, player.HighScore, accounts);
            }

            uberGameData.DestoryText();

            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {


            if (player.Score > player.HighScore)
            {
                player.HighScore = player.Score;
                //Change this to User when production na
                uberGameData.ScoreChanges(User, player.HighScore, accounts);
            }



        }
    }
}
