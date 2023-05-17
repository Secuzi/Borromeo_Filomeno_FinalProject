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
            //When the form loads it will get the accounts from the Database

            InitializeComponent();
            uberGameData = new clsDatabase();
            accounts = new List<clsAccount>(uberGameData.GetAccountsInDatabase());

            //This will get the unique instance made from logging in
            
            User = uberGameData.GetAccountFromForm();


            GameStart();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //When the left or right arrow is held then the player will move acordingly
            player.KeyIsUpEvent(e);

            //If the IsGameOver is true then the player is eligible to restart the game
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
                //If the user tries to resume the game while the game is over then it won't happen
                if (game.IsGameOver)
                {
                    pbResume.Enabled = false;
                    panelOptions.Enabled = true;
                    panelOptions.Visible = true;
                    panelOptions.BringToFront();
                }
                else
                {
                    //If the IsGameOver is false then the user can pause the game
                    panelOptions.Enabled = !panelOptions.Enabled;
                    panelOptions.Visible = !panelOptions.Visible;
                    panelOptions.BringToFront();

                    //After the panelOptions is visible then the game will momentarily stop
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

        //This will be the basis for initializing and starting the game
        private void GameStart()
        {
            //When the form loads the cursor will be set to the image that I imported to resources.
            Cursor customCursor = new Cursor(Resources.sCursor.GetHicon());
            this.Cursor = customCursor;

            
            panelOptions.Enabled = false;
            panelOptions.Visible = false;

            game.IsGameOver = false;
            pbPlayer.Image = Resources.playerIdle;
            
            clsAccount playerG = new clsAccount();

            //Finds if the Username or Email of the user exists in the Accounts database.                                           
            playerG = accounts.Find(a => a.Username == User || a.Email == User);

            player = new UVPlayer(pbPlayer, 10);

            player.Name = User;
            player.HighScore = playerG.Score;

            player.IsShooting = false;
            player.bullet = bullet;
            //Gets the enemies from this form and specifically instantiates it depending on the enemies' tag property.
            UVEnemy.SortEnemies(this.Controls);
            //Resets the Enemy to the top of the canvas
            UVEnemy.ResetEnemies();
            player.Score = 0;
            bullet.PbBullet = pbBullet;
            bullet.BulletSpeed = 0;
            bullet.PbBullet.Left = -300;
            pbAmmoCrate.Top = -500;
            bullet.BulletCount = 30;
            lblBulletCount.Text = bullet.BulletCount.ToString();
            lblScore.Text = player.Score.ToString();
            

            timerGame.Start();


        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            
            if (game.IsGameOver == true)
            {
                timerGame.Stop();
                
                //When the game is over it will check if the current score of the player is greater than the highscore
                //If so then the value will be replaced

                if (player.Score > player.HighScore)
                {
                    player.HighScore = player.Score;
                                             
                    uberGameData.ScoreChanges(User, player.HighScore, accounts);
                }


                pbResume.Enabled = false;
                pbPlayer.Image = Resources.explosion;
                lblGameOver.Visible = true;
                panelOptions.BringToFront();
                panelOptions.Enabled = true;
                panelOptions.Visible = true;
                lblRestart.Visible = true;
                
                
            }
            else
            {
                //This will be the main mechanics for movement and attacks for the player.

                player.GameTimerTickEvent(pbPlayer, this);
                
                UVEnemy.EnemyMovement(player, game);
                
                UVPlayer.SpawnAmmoCrate(pbAmmoCrate, player);

                //Changes the color depending on how many bullets the player has left.
                player.ChangeBulletColor(lblBulletCount);

                //This will be responsible for the scrolling of the pictureboxes so that it gives the effect of moving.
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

            //Redraws the canvas
            this.Invalidate();
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
            //Same as before, replaces the value if the current score is greater than highscore 
            if (player.Score > player.HighScore)
            {
                player.HighScore = player.Score;
                
                uberGameData.ScoreChanges(User, player.HighScore, accounts);
            }
            //This will destory the text that we have uniquely imported to the AccountForm database
            uberGameData.DestoryText();

            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {

            //Same as before, replaces the value if the current score is greater than highscore 
            if (player.Score > player.HighScore)
            {
                player.HighScore = player.Score;
                //Change this to User when production na
                uberGameData.ScoreChanges(User, player.HighScore, accounts);
            }

            //Instantiates the homepage form
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();

        }
    }
}
